using KengPgModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KengPgModel.Controllers
{
    public class HomeController : Controller
    {
        PGDbContext m_context;
        public HomeController()
        {
            m_context = new PGDbContext();
        }
        public ActionResult Index()
        {
            var data = m_context.Customers.ToList();
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