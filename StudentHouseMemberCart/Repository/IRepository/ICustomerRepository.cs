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
        public void DeleteCustomer(CustomerManagement p);
        public void addCustomer(CustomerManagement p);
        public void updateCustomer(CustomerManagement p);
        List<CustomerManagement> GetCustomer();
        List<CustomerManagement> SearchByType(String keyword, string type);
        CustomerManagement GetCustomerbyId(int id);

        public Boolean CheckLogin(String email, String password);
        CustomerManagement GetCustomerByEmail(String email);

    }
}
