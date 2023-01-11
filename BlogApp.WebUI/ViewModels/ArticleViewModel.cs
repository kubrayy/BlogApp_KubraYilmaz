using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Entity;

namespace BlogApp.WebUI.ViewModels
{
	public class PageInfo
	{
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string? CurrentCategory { get; set; }

        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }
    }
    public class ArticleViewModel
    {
        public PageInfo PageInfo { get; set; } = null!;
        public List<Article> Articles { get; set; } = null!;

    }
}

