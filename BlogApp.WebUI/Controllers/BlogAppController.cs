using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlogApp.Business.Abstract;
using BlogApp.Business.Concrete;
using BlogApp.Entity;
using BlogApp.WebUI.Models;
using BlogApp.WebUI.ViewModels;

namespace BlogApp.WebUI.Controllers
{
	public class BlogAppController : Controller
	{
        private IArticleService _articleService;

        public BlogAppController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string category, int page = 1)
        {
            const int pageSize = 3;
            List<Article> articles = _articleService.GetArticlesByCategory(category, page, pageSize);

            PageInfo pageInfo = new PageInfo()
            {
                TotalItems = _articleService.GetCountByCategory(category),
                CurrentPage = page,
                ItemsPerPage = pageSize,
                CurrentCategory = category
            };

            ArticleViewModel articleViewModel = new ArticleViewModel()
            {
                Articles = articles,
                PageInfo = pageInfo
            };
            return View(articleViewModel);
        }

        public IActionResult Details(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return NotFound();
            }
            Article article = _articleService.GetArticleDetails(url);
            ArticleDetailModel articleDetailModel = new ArticleDetailModel()
            {
                Article = article,
                Categories = article
                    .ArticleCategories
                    .Select(ac => ac.Category)
                    .ToList()
            };
            return View(articleDetailModel);
        }

        public IActionResult Search(string q)
        {
            List<Article> searchResult = _articleService.GetSearchResult(q);
            return View(searchResult);
        }
    }
}

