using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Entity;

namespace BlogApp.WebUI.Models
{
	public class ArticleDetailModel
	{
        public Article Article { get; set; } = null!;
        public List<Category> Categories { get; set; } = null!;
    }
}

