using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponent
{
    public class LatestArticleViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Articles = new List<Article>()
            {
                new Article(1 , "آموزش APS.net Core MVC" , "درخواست تاکسی" ,"blog-post-thumb-card-1.jpg") ,
                new Article(1 , "آموزش Vue.JS" , "مدارس" ,"blog-post-thumb-card-2.jpg" ) ,
                new Article(1 , "آموزش Laravel" , "زودی برام غذا بیار" ,"blog-post-thumb-card-3.jpg" ) ,
            };
            return View("_LatestArticles" , Articles);
        }
    }
}
