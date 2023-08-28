using Microsoft.AspNetCore.Mvc;
using Sport.Dal;
using Sport.Models;
using System.Diagnostics;

namespace Sport.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ArticleServices _articleServices;

        public HomeController(ILogger<HomeController> logger, ArticleServices articleServices)
        {
            _logger = logger;
            _articleServices = articleServices;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Sport";
            var articles = await _articleServices.GetArticles();
            return View(articles);
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Privacy Policy";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About Our Organization";
            
            return View();
        }

        public async Task<IActionResult> Article(int articleId) 
        {
            var article = await _articleServices.GetArticle(articleId);
            if (article == null) 
                return View("NotFound");

            return View(article);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}