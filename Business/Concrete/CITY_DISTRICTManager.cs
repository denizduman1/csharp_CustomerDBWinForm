using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CITY_DISTRICTManager : ICITY_DISTRICTService
    {
        ICITY_DISTRICTDal _cityDal;
        public CITY_DISTRICTManager(ICITY_DISTRICTDal cityDal)
        {
            _cityDal = cityDal;
        }

        public List<CITY_DISTRICT> GetAll()
        {
            return _cityDal.GetAll();
        }
        public List<string> GetCity()
        {
            return _cityDal.GetCity();
        }

        public List<string> GetTown(string text)
        {
            return _cityDal.GetAll().Where(p => p.CITY == text).Select(p => p.TOWN).ToList();
        }
    }
}
