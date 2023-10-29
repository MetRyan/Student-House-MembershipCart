using BussinenssObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOS
{
    public class CustomerDAOs
    {
        private static CustomerDAOs instance;
        private static object instanceLock = new object();
        public static CustomerDAOs Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAOs();
                }
                return instance;
            }
        }
        public static List<Customer> GetCustomers()
        {

            List<Customer> listCustomer = new List<Customer>();
            try
            {

                using (var context = new StudentHouseMembershipContext()) //goi toi database
                {
                    listCustomer = context.Customers.ToList();


                }

            }
            catch (Exception e)
            {


                throw new Exception(e.Message);


            }



            return listCustomer;
        }
        public static Customer GetCustomerbyId(int id)
        {
            Customer product = new Customer();
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    product = context.Customers.SingleOrDefault(m => m.CustomerId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }
        public static void AddCustomer(Customer customer)
        {
            try
            {

                using (var context = new StudentHouseMembershipContext())
                {

                    context.Customers.Add(customer);
                    context.SaveChanges();

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static void DeleteCustomer(Customer customer)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    var p1 = context.Customers.SingleOrDefault(m => m.CustomerId == customer.CustomerId);
                    context.Customers.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }


        }
        public static void UpdateCustomer(Customer customer)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Entry<Customer>(customer).State = EntityState.Modified; ;
                    context.SaveChanges();


                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "sdsdsds");

            }


        }

        public static Boolean CheckLogin(String email, String password)
        {
            try
            {
                using (var Context = new StudentHouseMembershipContext())
                {
                    var temp = Context.Customers.SingleOrDefault(p => p.Email == email
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
        public static Customer GetCustomerbyEmail(String email)
        {
            Customer Customer = new Customer();
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    Customer = context.Customers.SingleOrDefault(m => m.Email == email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Customer;
        }
        public static List<Customer> SearchByType(String keyword, String Type)
        {

            using (var context = new StudentHouseMembershipContext())

                if (Type == "Phone")
            {
                try
                {
                    return  context.Customers.Where(p=> p.Phone.Contains(keyword)).ToList();

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

                    return context.Customers.Where(p => p.LastName.Contains(keyword)).ToList()
                            .Where(p=>p.FirstName.Contains(keyword)).ToList();  


                }
                catch (FormatException ex)
                {
                    // Log error 
                    throw new Exception($"Invalid keyword for Name: {keyword}", ex);
                    // Throw again or return empty result
                }
            }
            return new List<Customer>();

        }


    }

    }