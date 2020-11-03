using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        void AddCustomer(Customer customer);
        void Updated(Customer customer);
        List<Customer> GetCustomerSearch(string text);
        void Delete(Customer customer);
    }
}
