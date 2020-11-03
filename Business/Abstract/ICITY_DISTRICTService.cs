using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICITY_DISTRICTService
    {
        List<CITY_DISTRICT> GetAll();
        List<string> GetCity();
        List<string> GetTown(string text);
    }
}
