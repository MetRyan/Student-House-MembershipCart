namespace Repository.Repository
{
    public class CustomerRepository
    {
        public void addCustomer(Customer p) => CustomerDAO.AddCustomer(p);

        public void DeleteCustomer(Customer p) => CustomerDAO.DeleteCustomer(p);


        public Customer GetCustomerbyId(int id) => CustomerDAO.GetCustomerbyId(id);

        public List<Customer> GetCustomer() => CustomerDAO.GetCustomers();

        public void updateCustomer(Customer p) => CustomerDAO.UpdateCustomer(p);

        public bool CheckLogin(String email, String password) => CustomerDAO.CheckLogin(email, password);
        public Customer GetCustomerByEmail(String email) => CustomerDAO.GetCustomerbyEmail(email);
    }
}