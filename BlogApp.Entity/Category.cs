using System;
namespace BlogApp.Entity
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? Url { get; set; }
		public List<ArticleCategory> ArticleCategories { get; set; } = null!;
	}
}

