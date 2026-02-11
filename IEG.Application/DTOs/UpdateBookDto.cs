using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEG.Application.DTOs.Books
{
    public class UpdateBookDto
    {
        [Required]
        public int Id { get; set; }

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
