using System;
using BlogApp.Business.Abstract;
using BlogApp.Data.Abstract;
using BlogApp.Entity;

namespace BlogApp.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private IArticleRepository _articleRepository;

        public ArticleManager(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public void Create(Article entity)
        {
            throw new NotImplementedException();
        }

        public void Create(Article entity, int[] categoryIds)
        {
            _articleRepository.Create(entity, categoryIds);
        }

        public void Delete(Article entity)
        {
            throw new NotImplementedException();
        }

        public List<Article> GeetAllArticles()
        {
            return _articleRepository.GetAllArticles();
        }

        public List<Article> GetAll()
        {
            return _articleRepository.GetAll();
        }

        public List<Article> GetApprovedArticles()
        {
            return _articleRepository.GetApprovedArticles();
        }

        public Article GetArticleDetails(string url)
        {
            return _articleRepository.GetArticleDetails(url);
        }

        public List<Article> GetArticlesByCategory(string category, int page, int pageSize)
        {
            return _articleRepository.GetArticlesByCategory(category, page, pageSize);
        }

        public Article GetArticleWithCategories(int id)
        {
            return _articleRepository.GetArticleWithCategories(id);
        }

        public Article GetById(int id)
        {
            return _articleRepository.GetById(id);
        }

        public int GetCountByCategory(string category)
        {
            return _articleRepository.GetCountByCategory(category);
        }

        public List<Article> GetDeletedArticles()
        {
            return _articleRepository.GetDeletedArticles();
        }

        public List<Article> GetHomePageArticles()
        {
            return _articleRepository.GetHomePageArticles();
        }

        public List<Article> GetSearchResult(string searchString)
        {
            return _articleRepository.GetSearchResult(searchString);
        }

        public void IsDelete(Article article)
        {
            _articleRepository.IsDelete(article);
        }

        public void Update(Article entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Article entity, int[] categoryIds)
        {
            _articleRepository.Update(entity, categoryIds);
        }

        public void UpdateIsApproved(Article article)
        {
            _articleRepository.UpdateIsApproved(article);
        }

        public void UpdateIsHome(Article article)
        {
            _articleRepository.UpdateIsHome(article);
        }
    }
}

