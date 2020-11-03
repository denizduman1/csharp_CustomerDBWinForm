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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerdal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerdal = customerDal;
        }
        public List<Customer> GetAll()
        {
            return _customerdal.GetAll();
        }

        public void AddCustomer(Customer customer)
        {
            _customerdal.Add(customer);
        }

        public void Updated(Customer customer)
        {
            _customerdal.Update(customer);
        }

        public List<Customer> GetCustomerSearch(string text)
        {
            return _customerdal.GetAll().Where(p => p.NAMESURNAME.ToLower().Contains(text.ToLower())).ToList();
        }

        public void Delete(Customer customer)
        {
            _customerdal.Delete(customer);
        }
    }
}
