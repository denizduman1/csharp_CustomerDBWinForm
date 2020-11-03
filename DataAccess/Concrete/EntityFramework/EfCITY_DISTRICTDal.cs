using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCITY_DISTRICTDal : EntityRepositoryBase<CITY_DISTRICT, CRMContext>, ICITY_DISTRICTDal
    {
        public List<string> GetCity()
        {
            using (CRMContext context = new CRMContext())
            {
                List<string> cities = context.CITY_DISTRICTs.Select(q => q.CITY).ToList();
                List<string> goncities = new List<string>();
                for (int i = 0; i < cities.Count; i++)
                {
                    if (goncities.Contains(cities[i]))
                    {
                        continue;
                    }
                    else
                    {
                        goncities.Add(cities[i]);
                    }
                }
                return goncities;
            }
        }

        public List<string> GetTown(string text)
        {
            throw new NotImplementedException();
        }
    }
}