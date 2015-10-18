using HateCrimeDB.Domain;
using HateCrimeDB.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HateCrimeDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExcelReaderServices _excelReaderServices;

        public HomeController(IExcelReaderServices excelReaderServices)
        {
            _excelReaderServices = excelReaderServices;
        }

        public ActionResult Index()
        {
            IEnumerable<Incident> incidents = _excelReaderServices.GetIncidents();
            return View();
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