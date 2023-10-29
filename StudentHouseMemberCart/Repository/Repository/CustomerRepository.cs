using BussinenssObject.Models;
using DAOS;
using Repository.IRepository;

namespace Repository.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public void addCustomer(Customer p) => CustomerDAOs.AddCustomer(p);

        public void DeleteCustomer(Customer p) => CustomerDAOs.DeleteCustomer(p);


        public Customer GetCustomerbyId(int id) => CustomerDAOs.GetCustomerbyId(id);

        public List<Customer> GetCustomer() => CustomerDAOs.GetCustomers();

        public void updateCustomer(Customer p) => CustomerDAOs.UpdateCustomer(p);

        public bool CheckLogin(String email, String password) => CustomerDAOs.CheckLogin(email, password);
        public Customer GetCustomerByEmail(String email) => CustomerDAOs.GetCustomerbyEmail(email);

        public List<Customer> SearchByType(string keyword, string type) => CustomerDAOs.SearchByType(keyword, type);
    }
}