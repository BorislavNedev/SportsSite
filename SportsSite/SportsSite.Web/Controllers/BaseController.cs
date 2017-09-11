namespace SportsSite.Web.Controllers
{
    using SportsSite.Data.UnitOfWork;
    using System.Web.Mvc;

    public class BaseController : Controller
    {
        protected ISportsSiteData Data;

        public BaseController(ISportsSiteData data)
        {
            this.Data = data;
        }

        public BaseController()
            : this(new SportsSiteData())
        {
        }
    }
}