using System;
using Entity.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICITY_DISTRICTDal:IEntityRepositoryBase<CITY_DISTRICT>
    {
        List<string> GetCity();
        List<string> GetTown(string text);
    }
}
