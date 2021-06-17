using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationTestP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string command)
        {
            TestRepository testRepository = new TestRepository();
            if (String.IsNullOrEmpty(command))
            {
                return View(testRepository.FindAllCompanies());
            }
            else 
            {
                command = string.Empty;
                List<Company> companies = new List<Company>();
                companies = testRepository.FindAllCompanies();
                companies =companies.Where(a => a.Type == "Entities.IrishCompany").ToList();
                return View(companies); ;
            }
        }
        [HttpPost]
        public ActionResult Search()
        {

          return  RedirectToAction("index", "home", new { command = "Find Irish" });
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