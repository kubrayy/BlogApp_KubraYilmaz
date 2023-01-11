using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Entity;

namespace BlogApp.Data.Abstract
{
	public interface IArticleRepository : IRepository<Article>
	{
		List<Article> GetArticlesByCategory(string category, int page, int pageSize);
		List<Article> GetHomePageArticles();
		List<Article> GetApprovedArticles();
		Article GetArticleDetails(string url);
		int GetCountByCategory(string category);
		List<Article> GetSearchResult(string searchString);
		void Create(Article article, int[] categoryIds);
		void Update(Article article, int[] categoryIds);
		Article GetArticleWithCategories(int id);
		void UpdateIsHome(Article article);
		void UpdateIsApproved(Article article);
		void IsDelete(Article article);
		List<Article> GetAllArticles();
		List<Article> GetDeletedArticles();
	}
}
