using System;
namespace BlogApp.Entity
{
	public class Article
	{
		public int ArticleId { get; set; }
		public string? Name { get; set; }
		public string? Content { get; set; }
		public string ImageUrl { get; set; }
		public string? Url { get; set; }
		public string AuthorName { get; set; }
		public string AuthorPhoto { get; set; }
		public bool IsHome { get; set; }
		public bool IsApproved { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime DateAdded { get; set; }
		public List<ArticleCategory> ArticleCategories { get; set; } = null!;
	}
}

