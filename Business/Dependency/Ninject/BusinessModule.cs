using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dependency.Ninject
{
    public class BusinessModule : NinjectModule
    {
        //değiştirmek istediğimizde burada işlemlerimizi yapmamız yeterli olacak.
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope() ;
            Bind<ICustomerDal>().To<EFCustomerDal>().InSingletonScope();
            Bind<ICITY_DISTRICTService>().To<CITY_DISTRICTManager>().InSingletonScope();
            Bind<ICITY_DISTRICTDal>().To<EfCITY_DISTRICTDal>().InSingletonScope();
        }
    }
}
