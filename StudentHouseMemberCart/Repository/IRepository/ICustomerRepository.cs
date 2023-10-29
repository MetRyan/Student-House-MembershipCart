using BussinenssObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface ICustomerRepository
    {
        public void DeleteCustomer(Customer p);
        public void addCustomer(Customer p);
        public void updateCustomer(Customer p);
        List<Customer > GetCustomer();
        List<Customer> SearchByType(String keyword, string type);
        Customer GetCustomerbyId(int id);

        public Boolean CheckLogin(String email, String password);
        Customer GetCustomerByEmail(String email);

    }
}
