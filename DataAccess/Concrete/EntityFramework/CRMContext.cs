using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CRMContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CITY_DISTRICT> CITY_DISTRICTs { get; set; }
    }
}
