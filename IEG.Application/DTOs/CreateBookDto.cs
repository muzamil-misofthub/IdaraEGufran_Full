using System.ComponentModel.DataAnnotations;


namespace IEG.Application.DTOs.Books
{
    public class CreateBookDto
    {
        [Required]
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? ReleaseDate { get; set; }
        public string? ImageUrl { get; set; }
        public string? BackgroundImageUrl { get; set; }
    }
}
