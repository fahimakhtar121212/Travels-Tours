using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasomeenTravels.Web.ViewModel
{
    public class VMCompanyInfo
    {
        public int AboutCompanyID { get; set; }
        public String CompanyName { get; set; }
        public String CompanyLogo { get; set; }
        public String Description { get; set; }
        public String CompanyVision { get; set; }
        public String Established { get; set; }
        public String Address { get; set; }
        public String EmailAddress { get; set; }
        public String Mobile { get; set; }
        public String LandLine { get; set; }
        public String Fax { get; set; }
        public String LocationMap { get; set; }
    }
}