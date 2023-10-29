using BussinenssObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DAOS
{
    public class CustomerDAOs
    {
        private static CustomerDAOs instance;
        private static object instanceLock = new object();
        private CustomerDAOs()
        {

        }
        public static CustomerDAOs Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAOs();
                    }
                    return instance;
                }
            }
        }
        public static List<CustomerT> GetCustomers()
        {

            List<CustomerT> listCustomer = new List<CustomerT>();
            try
            {

                using (var context = new StudentHouseMembershipContext()) //goi toi database
                {
                    listCustomer = context.CustomerTs.ToList();  


                }

            }
            catch (Exception e)
            {


                throw new Exception(e.Message);


            }



            return listCustomer;
        }
        public static CustomerT GetCustomerbyId(int id)
        {
            CustomerT product = new CustomerT();
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    product = context.CustomerTs.SingleOrDefault(m => m.CustomerId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }
        public static void AddCustomer(CustomerT customer)
        {
            try
            {

                using (var context = new StudentHouseMembershipContext())
                {

                    context.CustomerTs.Add(customer);
                    context.SaveChanges();

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static void DeleteCustomer(CustomerT customer)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    var p1 = context.CustomerTs.SingleOrDefault(m => m.CustomerId == customer.CustomerId);
                    context.CustomerTs.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }


        }
        public static void UpdateCustomer(CustomerT customer)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Entry<CustomerT>(customer).State = EntityState.Modified; ;
                    context.SaveChanges();


                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Error");

            }


        }

        public static Boolean CheckLogin(String email, String password)
        {
            try
            {
                using (var Context = new StudentHouseMembershipContext())
                {
                    var temp = Context.CustomerTs.SingleOrDefault(p => p.Email == email
                    && p.Password == password);
                    if (temp != null)
                    { return true; }

                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "");

            }




        }
        public static CustomerT GetCustomerbyEmail(String email)
        {
            CustomerT Customer = new CustomerT();
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    Customer = context.CustomerTs.SingleOrDefault(m => m.Email == email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Customer;
        }
        public static List<CustomerT> SearchByType(String keyword, String Type)
        {

            using (var context = new StudentHouseMembershipContext())

                if (Type == "Phone")
                {
                    return  context.CustomerTs.Where(p=> p.Phone.Contains(keyword)).ToList();
                    try
                    {
                        return context.CustomerTs.Where(p => p.Phone.Contains(keyword)).ToList();
                    }
                    catch (FormatException ex)
                    {
                        // Log error 
                        throw new Exception($"Invalid keyword for Phone: {keyword}", ex);
                        // Throw again or return empty result
                    }
                }
                else if (Type == "Name")
                {
                    try
                    {

                    return context.CustomerTs.Where(p => p.LastName.Contains(keyword)).ToList()
                            .Where(p=>p.FirstName.Contains(keyword)).ToList();  
                        return context.CustomerTs.Where(p => p.LastName.Contains(keyword)).ToList()
                                .Where(p => p.FirstName.Contains(keyword)).ToList();


                    }
                    catch (FormatException ex)
                    {
                        // Log error 
                        throw new Exception($"Invalid keyword for Name: {keyword}", ex);
                        // Throw again or return empty result
                    }
             
            }
            return new List<CustomerT>();

        }


    }

}