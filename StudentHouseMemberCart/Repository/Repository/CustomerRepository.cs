using BussinenssObject.Models;
using DAOS;
using Repository.IRepository;

namespace Repository.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public void addCustomer(CustomerT p) => CustomerDAOs.AddCustomer(p);

        public void DeleteCustomer(CustomerT p) => CustomerDAOs.DeleteCustomer(p);


        public CustomerT GetCustomerbyId(int id) => CustomerDAOs.GetCustomerbyId(id);

        public List<CustomerT> GetCustomer() => CustomerDAOs.GetCustomers();

        public void updateCustomer(CustomerT p) => CustomerDAOs.UpdateCustomer(p);

        public bool CheckLogin(String email, String password) => CustomerDAOs.CheckLogin(email, password);
        public CustomerT GetCustomerByEmail(String email) => CustomerDAOs.GetCustomerbyEmail(email);

        public List<CustomerT> SearchByType(string keyword, string type) => CustomerDAOs.SearchByType(keyword, type);
    }
}