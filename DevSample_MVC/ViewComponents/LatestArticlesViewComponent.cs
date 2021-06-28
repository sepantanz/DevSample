using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevSample_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevSample_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>()
            {
                new Article(1, "Asp.Net Core MVC", "آموزش کامل برنامه‌نویسی وب", "blog-post-thumb-card-1.jpg"),
                new Article(2, "Git & Github", "آموزش کامل گیت و گیت هاب", "blog-post-thumb-card-2.jpg"),
                new Article(3, "Onion Architecture", "آموزش کامل برنامه‌نویسی چند لایه", "blog-post-thumb-card-3.jpg"),
                new Article(4, "HTML & CSS", "آموزش کامل طراحی وب", "blog-post-thumb-card-4.jpg"),
            };
            return View("_LatestArticles", articles);
        }
    }
}
