using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc ;



namespace DevCard_MVC.ViewComponent
{
    public class ProjectsViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var Projects = new List<Project>()
            {
                new Project(1 , "تاکسی" , "درخواست تاکسی" ,"project-1.jpg" , "tAXImENT") ,
                new Project(1 , "مدارس" , "مدارس" ,"project-2.jpg"  , "School") ,
                new Project(1 , "فودمنت" , "زودی برام غذا بیار" ,"project-3.jpg" , "Foodment") ,
                new Project(1 , "کالامنت" , "کالامنت" ,"project-4.jpg"  , "kalament") ,
            };

            return View("_Projects" , Projects);
        }

    }
}
