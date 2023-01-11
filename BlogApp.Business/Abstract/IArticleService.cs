using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Entity;

namespace BlogApp.Business.Abstract
{
	public interface IArticleService
	{
		Article GetById(int id);
		List<Article> GetAll();
		void Create(Article entity);
		void Create(Article entity, int[] categoryIds);
		void Update(Article entity);
		void Update(Article entity, int[] categoryIds);
		void Delete(Article entity);
		void IsDelete(Article article);
		List<Article> GetHomePageArticles();
		List<Article> GetApprovedArticles();
		Article GetArticleDetails(string url);
		List<Article> GetArticlesByCategory(string category, int page, int pageSize);
		int GetCountByCategory(string category);
		List<Article> GetSearchResult(string searchString);
		Article GetArticleWithCategories(int id);
		void UpdateIsHome(Article article);
		void UpdateIsApproved(Article article);
		List<Article> GeetAllArticles();
		List<Article> GetDeletedArticles();
	}
}

