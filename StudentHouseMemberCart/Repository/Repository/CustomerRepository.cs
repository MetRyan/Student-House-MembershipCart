using BussinenssObject.Models;
using DAOS;
using Repository.IRepository;

namespace Repository.Repository
{
    public class CustomerRepository :ICustomerRepository
    {
        public void addCustomer(CustomerManagement p) => CustomerDAOs.AddCustomer(p);

        public void DeleteCustomer(CustomerManagement p) => CustomerDAOs.DeleteCustomer(p);


        public CustomerManagement GetCustomerbyId(int id) => CustomerDAOs.GetCustomerbyId(id);

        public List<CustomerManagement> GetCustomer() => CustomerDAOs.GetCustomers();

        public void updateCustomer(CustomerManagement p) => CustomerDAOs.UpdateCustomer(p);

        public bool CheckLogin(String email, String password) => CustomerDAOs.CheckLogin(email, password);
        public CustomerManagement GetCustomerByEmail(String email) => CustomerDAOs.GetCustomerbyEmail(email);
    CustomerDAOs
}