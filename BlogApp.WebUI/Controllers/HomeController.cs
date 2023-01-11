using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Data.Concrete.EfCore;
using BlogApp.WebUI.Models;
using BlogApp.Business.Concrete;
using BlogApp.Entity;
using BlogApp.WebUI.ViewModels;
using BlogApp.Business.Abstract;

namespace BlogApp.WebUI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IArticleService _articleService;

    public HomeController(ILogger<HomeController> logger, IArticleService articleService)
    {
        _logger = logger;
        _articleService = articleService;
    }

    public IActionResult Index()
    {

        List<Article> articles = _articleService.GetHomePageArticles();

        ArticleViewModel viewModel = new ArticleViewModel();
        viewModel.Articles = articles;

        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

