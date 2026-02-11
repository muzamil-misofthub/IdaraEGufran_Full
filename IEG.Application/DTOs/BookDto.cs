namespace IEG.Application.DTOs.Books
{
    public class BookDto
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public string? Description { get; set; }

        public string? Author { get; set; }

        public string? Publisher { get; set; }

        public required string? ReleaseDate { get; set; }

        public string? ImageUrl { get; set; }

        public string? BackgroundImageUrl { get; set; }
    }
}
