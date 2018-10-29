using MasomeenTravels.Database;
using MasomeenTravels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasomeenTravels.Services
{
    public class CompanyInfoService
    {
        MTContext db = new MTContext();

        public List<CompanyInfo> GetCompanyInfo()
        {           
            return db.CompanyInfos.ToList();
        }
    }
}
