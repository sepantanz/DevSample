using System.Collections.Generic;
using DevSample_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevSample_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی", "project-1.jpg", "Snapp"),
                new Project(2, "زودفود", "درخواست آنلاین غذا", "project-2.jpg", "Zoodfood"),
                new Project(3, "مدارس", "سیستم مدیریت یکپارچه‌ی مدارس", "project-3.jpg", "MONOP"),
                new Project(4, "فضاپیما", "برنامه‌ی مدیریت فضاپیماهای ناسا", "project-4.jpg", "NASA"),
            };
            return View("_Projects", projects);
        }
    }
}
