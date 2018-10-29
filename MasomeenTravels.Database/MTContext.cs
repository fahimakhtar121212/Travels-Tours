using MasomeenTravels.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasomeenTravels.Database
{
    public class MTContext : DbContext
    {
        public MTContext():base("MTConnection")
        {

        }

        public DbSet<MainSlider> MainSliders { get; set; }
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
    }
}
