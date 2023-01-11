using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public class EfCoreArticleRepository : EfCoreGenericRepository<Article>, IArticleRepository
    {
        public EfCoreArticleRepository(BlogAppContext dbContext) : base(dbContext)
        {

        }

        private BlogAppContext context
        {
            get { return _dbContext as BlogAppContext; }
        }

        public void Create(Article article, int[] categoryIds)
        {
            context.Articles.Add(article);
            context.SaveChanges();
            article.ArticleCategories = categoryIds
                .Select(catId => new ArticleCategory()
                {
                    ArticleId = article.ArticleId,
                    CategoryId = catId
                }).ToList();
            context.SaveChanges();
        }

        public List<Article> GetAllArticles()
        {
            return context
                .Articles
                .Where(a => a.IsDeleted == false)
                .ToList();
        }

        public List<Article> GetApprovedArticles()
        {
            return context
                .Articles
                .Where(a => a.IsApproved)
                .ToList();
        }

        public Article GetArticleDetails(string url)
        {
            return context
                .Articles
                .Where(a => a.Url == url)
                .Include(a => a.ArticleCategories)
                .ThenInclude(ac => ac.Category)
                .FirstOrDefault();
        }

        public List<Article> GetArticlesByCategory(string category, int page, int pageSize)
        {
            var articles = context.Articles.AsQueryable();
            if (!string.IsNullOrEmpty(category))
            {
                articles = articles
                .Where(a => a.IsApproved == true)
                .Include(a => a.ArticleCategories)
                .ThenInclude(ac => ac.Category)
                .Where(a => a.ArticleCategories.Any(ac => ac.Category.Url == category));
            };
            return articles
              .Skip(page - 1 * pageSize)
              .Take(pageSize)
              .ToList();
        }

        public Article GetArticleWithCategories(int id)
        {
            return context
                .Articles
                .Where(a => a.ArticleId == id && a.IsDeleted == false)
                .Include(a => a.ArticleCategories)
                .ThenInclude(ac => ac.Category)
                .FirstOrDefault();
        }

        public int GetCountByCategory(string category)
        {
            var articles = context.Articles.AsQueryable();
            if (!string.IsNullOrEmpty(category))
            {
                articles = articles
                    .Where(a => a.IsApproved == true)
                    .Include(a => a.ArticleCategories)
                    .ThenInclude(ac => ac.Category)
                    .Where(a => a.ArticleCategories.Any(ac => ac.Category.Url == category));
            };
            return articles.Count();
        }

        public List<Article> GetDeletedArticles()
        {
            return context
                .Articles
                .Where(a => a.IsDeleted == true)
                .ToList();
        }

        public List<Article> GetHomePageArticles()
        {
            return context
                .Articles
                .Where(a => a.IsHome && a.IsApproved)
                .ToList();
        }

        public List<Article> GetSearchResult(string searchString)
        {
            return context
                .Articles
                .Where(a => a.IsApproved == true && (a.Name.ToLower().Contains(searchString.ToLower()) || a.Content.ToLower().Contains(searchString.ToLower())))
                .ToList();
        }

        public void IsDelete(Article article)
        {
            if (article.IsDeleted == false)
            {
                article.IsDeleted = true;
            }
            else
            {
                article.IsDeleted = false;
            }
            context.Update(article);
            context.SaveChanges();
        }

        public void Update(Article article, int[] categoryIds)
        {
            Article entity = context
            .Articles
            .Include(a => a.ArticleCategories)
            .FirstOrDefault(ac => ac.ArticleId == article.ArticleId);
            entity.Name = article.Name;
            entity.Content = article.Content;
            entity.Url = article.Url;
            entity.ImageUrl = article.ImageUrl;
            entity.IsApproved = article.IsApproved;
            entity.IsHome = article.IsHome;
            entity.ArticleCategories = categoryIds
                .Select(catId => new ArticleCategory()
                {
                    ArticleId = entity.ArticleId,
                    CategoryId = catId
                }).ToList();
            context.Update(entity);
            context.SaveChanges();
        }

        public void UpdateIsApproved(Article article)
        {
            if (article.IsApproved)
            {
                article.IsApproved = false;
            }
            else
            {
                article.IsApproved = true;
            };
            context.Entry(article).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void UpdateIsHome(Article article)
        {
            if (article.IsHome)
            {
                article.IsHome = false;
            }
            else
            {
                article.IsHome = true;
            };
            context.Entry(article).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

