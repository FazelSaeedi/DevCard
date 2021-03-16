using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        /*public EmptyResult Index()
        {
            return null;
        }*/

        /*public PartialViewResult Index()
        {
             return PartialView("Footer");
        }*/

        /*public ContentResult Index()
        {
             return Content("<h1> Hi Baby <h2>", "text/html");
        }*/

        /*public FileResult Index()
        {
            // return File("~/test.txt" , "text/html");

            var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");

            const string fileName = "test.txt";

            return File(fileName, MediaTypeNames.Text.Plain);
        }*/

        /*public JsonResult Index()
        {
            return Json(new
                {
                    id = 12,
                    name = "fazel",
                    job = "programer",
                    site = "fazelTsaeedi.ir"
                }
            );
        }*/

        /*public JavascriptResult Index()
        {
            return new JavascriptResult("alert('Hi Baby')");
        }*/

        /*public RedirectResult Index()
        {
            return Redirect("http://www.FazelTsaeedi.ir");
        }*/

        /*public RedirectToActionResult Index()
        {
            return RedirectToAction("Contact", "Home");
        }*/

        public IActionResult Index()
        {
            return new OkResult();
        }

        public JsonResult Contact(ContactForm form)
        {
            return Json(Ok());
        }

    }

        public class JavascriptResult : ContentResult
    {
        public JavascriptResult(string data)
        {
            Content = data;
            ContentType = "application/javascript";
        }
    }
}