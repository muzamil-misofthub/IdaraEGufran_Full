using IEG.Application.DTOs.Books;
using IEG.Domain.Entities;

namespace IEG.Application.Mappings
{
    public static class BookMappings
    {
        public static BookDto ToDto(this Book book) => new BookDto
        {
            Id = book.Id,
            Title = book.Title,
            Description = book.Description,
            Author = book.Author,
            Publisher = book.Publisher,
            ReleaseDate = book.ReleaseDate,
            ImageUrl = book.imageURL,
            BackgroundImageUrl = book.backgroundImageURL
        };

        public static Book ToEntity(this CreateBookDto d) => new Book
        {
            Title = d.Title,
            Description = d.Description,
            Author = d.Author,
            Publisher = d.Publisher,
            ReleaseDate = d.ReleaseDate ?? DateTime.MinValue.ToString(),
            imageURL = d.ImageUrl ?? string.Empty,
            backgroundImageURL = d.BackgroundImageUrl
        };

        public static void UpdateEntity(this UpdateBookDto ubDto, Book book)
        {
            book.Title = ubDto.Title;
            book.Description = ubDto.Description;
            book.Author = ubDto.Author;
            book.Publisher = ubDto.Publisher;
            book.ReleaseDate = ubDto.ReleaseDate ?? book.ReleaseDate;
            book.imageURL = ubDto.ImageUrl;
            book.backgroundImageURL = ubDto.BackgroundImageUrl;
        }

    }
}
