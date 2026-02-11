using IEG.Application.DTOs.Books;
using IEG.Application.Mappings;
using IEG.Application.Services;
using IEG.Domain.Entities;
using IEG.Domain.Interfaces;

namespace IEG.Infrastructure.Services;

public class BookService : IBookService
{
    private readonly IGenericRepository<Book> _repo;

    public BookService(IGenericRepository<Book> repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<BookDto>> GetAllBooksAsync(int page = 1, int pageSize = 20, string? q = null)
    {
        var all = await _repo.GetAllAsync();
        if (!string.IsNullOrWhiteSpace(q))
        {
            all = all.Where(b => (b.Title ?? "").Contains(q, StringComparison.OrdinalIgnoreCase)
                               || (b.Description ?? "").Contains(q, StringComparison.OrdinalIgnoreCase));
        }

        return all
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .Select(b => b.ToDto())
            .ToList();
    }

    public async Task<BookDto?> GetBookByIdAsync(int id)
    {
        var b = await _repo.GetByIdAsync(id);
        return b is null ? null : b.ToDto();
    }

    public async Task<BookDto> CreateBookAsync(CreateBookDto dto)
    {
        var entity = dto.ToEntity();
        await _repo.AddAsync(entity);
        return entity.ToDto();
    }

    public async Task<BookDto> UpdateBookAsync(UpdateBookDto dto)
    {
        var entity = await _repo.GetByIdAsync(dto.Id);
        if (entity is null) throw new KeyNotFoundException($"Book {dto.Id} not found.");
        dto.UpdateEntity(entity);
        await _repo.UpdateAsync(entity);
        return entity.ToDto();
    }

    public async Task DeleteAsync(int id)
    {
        await _repo.DeleteAsync(id);
    }
}
