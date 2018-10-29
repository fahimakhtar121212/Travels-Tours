using MasomeenTravels.Database;
using MasomeenTravels.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasomeenTravels.Web.Controllers
{
    public class SharedController : Controller
    {
        CompanyInfoService companyInfoService = new CompanyInfoService();
        // GET: Shared
        public ActionResult _Layout()
        {
            return View();
        }

        public ActionResult _Footer()
        {
            var companyInfo = companyInfoService.GetCompanyInfo();

            foreach (var item in companyInfo)
            {
                ViewBag.ComName = item.CompanyName;
                ViewBag.ComAddress = item.Address;
                ViewBag.ComMobile = item.Mobile;
                ViewBag.ComEmail = item.EmailAddress;
                ViewBag.ComLandLine = item.LandLine;
            }

            return PartialView();
        }
    }
}