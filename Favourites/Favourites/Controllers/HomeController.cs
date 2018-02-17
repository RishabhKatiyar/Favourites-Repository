namespace Favourites.Controllers
{
    using Favourites.Core.Interfaces;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private IFavouriteRepository repo;

        public HomeController(IFavouriteRepository repo)
        {
            this.repo = repo;
        }

        public ActionResult Index()
        {
            return View(repo.GetFavourites());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}