namespace SportsSite.Web.Controllers
{
    using SportsSite.Web.Models;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var listOfArticles = this.Data.Articles
                .All()
                .OrderByDescending(x => x.Date)
                .Select(x => new ArticleConciseViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Date = x.Date.ToString(),
                    ImageUrl = x.ImageUrl
                });
            return View(listOfArticles);
            
        }        
    }
}