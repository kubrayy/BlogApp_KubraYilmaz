using System;
using BlogApp.Entity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlogApp.WebUI.Models
{
	public class ArticleModel
	{
        public int ArticleId { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Name's length is 5-50")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Content is required!")]
        [StringLength(150, MinimumLength = 15, ErrorMessage = "15-150")]
        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public string? Url { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }
        [AllowNull]
        public List<Category> SelectedCategories { get; set; } = null!;
    }
}

