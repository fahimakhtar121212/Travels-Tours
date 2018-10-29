using MasomeenTravels.Database;
using MasomeenTravels.Entities;
using MasomeenTravels.Services;
using MasomeenTravels.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasomeenTravels.Web.Controllers
{
    public class HomeController : Controller
    {
        MTContext db = new MTContext();
        CompanyInfoService cInfoService = new CompanyInfoService();
        // GET: Home
        
        
        public ActionResult Index()
        {
            var Coninfo = cInfoService.GetCompanyInfo();

            foreach (var item in Coninfo)
            {
                ViewBag.CName = item.CompanyName;
                ViewBag.Address = item.Address;
                ViewBag.Mobile = item.Mobile;
                ViewBag.Email = item.EmailAddress;
                ViewBag.LandLine = item.LandLine;
            }
            ViewBag.MainSlider = db.MainSliders.ToList();

            return View();
        }

        [Route("Contact")]
        public ActionResult Contact()
        {
            var Coninfo = cInfoService.GetCompanyInfo();

            foreach (var item in Coninfo)
            {
                ViewBag.Address = item.Address;
                ViewBag.Contact = item.Mobile;
                ViewBag.Email = item.EmailAddress;
            }
            return View();
        }

        [Route("About")]
        public ActionResult About()
        {
            return View();
        }


        public ActionResult Blog()
        {
            ViewBag.CompanyName = "Masomeen Travels & Tours";
            return View();
        }
    }
}