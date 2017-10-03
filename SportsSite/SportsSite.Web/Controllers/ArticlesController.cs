namespace SportsSite.Web.Controllers
{
    using Microsoft.AspNet.Identity;
    using SportsSite.Models;
    using SportsSite.Web.Models;
    using System.Linq;
    using System.Web.Mvc;

    public class ArticlesController : BaseController
    {
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult PostComment(SubmitCommentModel commentModel)
        {
            if (ModelState.IsValid)
            {
                var userName = this.User.Identity.GetUserName();
                var userId = this.User.Identity.GetUserId();

                this.Data.Comments.Add(new Comment()
                {
                    AuthorId = userId,
                    Content = commentModel.Comment,
                    ArticleId = commentModel.ArticleId
                });

                this.Data.SaveChanges();

                var viewModel = new CommentViewModel { AuthorUsername = userName, Content = commentModel.Comment };
                return PartialView("_CommentPartial", viewModel);
            }
            else
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest, ModelState.Values.First().ToString());
            }
        }

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
                .OrderByDescending(x => x.Date)
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
                .OrderByDescending(x => x.Date)
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
                .OrderByDescending(x => x.Date)
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
                .OrderByDescending(x => x.Date)
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
                .OrderByDescending(x => x.Date)
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
                .OrderByDescending(x => x.Date)
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
                .OrderByDescending(x => x.Date)
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
                .OrderByDescending(x => x.Date)
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
                .OrderByDescending(x => x.Date)
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