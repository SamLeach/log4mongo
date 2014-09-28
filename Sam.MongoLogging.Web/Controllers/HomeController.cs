using System.Web.Mvc;

namespace Sam.MongoLogging.Web.Controllers
{
    using System.IO;

    using log4net.Config;

    using MongoDB.Driver;

    using Sam.MongoLogging.Logging;
    using Sam.MongoLogging.Web.Models;

    public class HomeController : Controller
    {
        private readonly ILogger logger;

        public HomeController(ILogger logger)
        {
            XmlConfigurator.Configure();
            this.logger = logger;
        }

        public ActionResult Index()
        {
            logger.Info("Home");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            logger.Info("About");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            logger.Info("Contact");
            return View();
        }
    }
}