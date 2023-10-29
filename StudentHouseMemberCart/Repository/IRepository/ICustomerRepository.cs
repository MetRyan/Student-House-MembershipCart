using BussinenssObject.Models;

namespace Repository.IRepository
{
    public interface ICustomerRepository
    {
        public void DeleteCustomer(CustomerT p);
        public void addCustomer(CustomerT p);
        public void updateCustomer(CustomerT p);
        List<CustomerT> GetCustomer();
        List<CustomerT> GetCustomers();
        List<CustomerT> SearchByType(String keyword, string type);
        CustomerT GetCustomerbyId(int id);

        public Boolean CheckLogin(String email, String password);
        CustomerT GetCustomerByEmail(String email);

    }
}
