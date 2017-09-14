namespace SportsSite.Web.Controllers
{
    using SportsSite.Web.Models;
    using System.Linq;
    using System.Web.Mvc;

    public class ArticlesController : BaseController
    {
        public ActionResult Details(int id)
        {
            var viewModel = this.Data.Articles
                .All()
                .Where(x => x.Id == id)
                .Select(x => new ArticleFullViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Content = x.Content,
                    ImageUrl = x.ImageUrl,
                    Category = x.Category.Name,
                    Date = x.Date.ToString()
                }).FirstOrDefault();

            return View(viewModel);
        }

        public ActionResult FootballArticles(int? id)
        {
            var viewModel = this.Data.Articles
                .All()
                .Where(x => x.Category.Name == "Football")
                .Select(x => new ArticleConciseViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Date = x.Date.ToString(),
                    ImageUrl = x.ImageUrl,
                });

            return View(viewModel);
        }

        public ActionResult BasketballArticles(int? id)
        {
            var viewModel = this.Data.Articles
                .All()
                .Where(x => x.Category.Name == "Basketball")
                .Select(x => new ArticleConciseViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Date = x.Date.ToString(),
                    ImageUrl = x.ImageUrl,
                });

            return View(viewModel);
        }

        public ActionResult VolleyballArticles(int? id)
        {
            var viewModel = this.Data.Articles
                .All()
                .Where(x => x.Category.Name == "Volleyball")
                .Select(x => new ArticleConciseViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Date = x.Date.ToString(),
                    ImageUrl = x.ImageUrl,
                });

            return View(viewModel);
        }

        public ActionResult TennisArticles(int? id)
        {
            var viewModel = this.Data.Articles
                .All()
                .Where(x => x.Category.Name == "Tennis")
                .Select(x => new ArticleConciseViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Date = x.Date.ToString(),
                    ImageUrl = x.ImageUrl,
                });

            return View(viewModel);
        }

        public ActionResult AthleticsArticles(int? id)
        {
            var viewModel = this.Data.Articles
                .All()
                .Where(x => x.Category.Name == "Athletics")
                .Select(x => new ArticleConciseViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Date = x.Date.ToString(),
                    ImageUrl = x.ImageUrl,
                });

            return View(viewModel);
        }

        public ActionResult FightSportsArticles(int? id)
        {
            var viewModel = this.Data.Articles
                .All()
                .Where(x => x.Category.Name == "Fight Sports")
                .Select(x => new ArticleConciseViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Date = x.Date.ToString(),
                    ImageUrl = x.ImageUrl,
                });

            return View(viewModel);
        }

        public ActionResult WinterSportsArticles(int? id)
        {
            var viewModel = this.Data.Articles
                .All()
                .Where(x => x.Category.Name == "Winter Sports")
                .Select(x => new ArticleConciseViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Date = x.Date.ToString(),
                    ImageUrl = x.ImageUrl,
                });

            return View(viewModel);
        }

        public ActionResult MotorSportsArticles(int? id)
        {
            var viewModel = this.Data.Articles
                .All()
                .Where(x => x.Category.Name == "Motor Sports")
                .Select(x => new ArticleConciseViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Date = x.Date.ToString(),
                    ImageUrl = x.ImageUrl,
                });

            return View(viewModel);
        }

        public ActionResult OtherArticles(int? id)
        {
            var viewModel = this.Data.Articles
                .All()
                .Where(x => x.Category.Name == "Other")
                .Select(x => new ArticleConciseViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Date = x.Date.ToString(),
                    ImageUrl = x.ImageUrl,
                });

            return View(viewModel);
        }
    }
}