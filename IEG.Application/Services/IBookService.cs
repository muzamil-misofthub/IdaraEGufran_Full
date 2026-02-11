using IEG.Application.DTOs.Books;

namespace IEG.Application.Services
{
    public interface IBookService
    {
        Task<IEnumerable <BookDto>> GetAllBooksAsync(int page=1, int pageSize = 20, string? q=null);

        Task<BookDto?> GetBookByIdAsync(int id);
        Task<BookDto> CreateBookAsync(CreateBookDto newBook);
        Task<BookDto> UpdateBookAsync(UpdateBookDto updatedBook);
        Task DeleteAsync(int id);
    }
}
