using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        [Route("custom/12312/2")]//isdediyin routu et)
        public string Custom()
        {
            return ReadAllFile($"\\Views\\Home\\Custom.html");
        }

        public static string AppRoot()
        {
            var exPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exPath ?? String.Empty).Value;
            return $"{appRoot}";
        }
        public static string ReadAllFile(string fileFullName)
        {
            return System.IO.File.ReadAllText($"{AppRoot()}\\{fileFullName}");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}