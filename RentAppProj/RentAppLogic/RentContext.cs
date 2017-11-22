using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAppLogic
{
    public class RentContext : DbContext
    {
        public DbSet<Nieruchomosc> Nieruchomosci { get; set; }
        public RentContext():base("baza1")
        {

        }
    }
}
