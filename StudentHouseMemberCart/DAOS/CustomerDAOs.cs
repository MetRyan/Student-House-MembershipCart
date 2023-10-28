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
        public static List<CustomerManagement> GetCustomers()
        {

            List<CustomerManagement> listCustomer = new List<CustomerManagement>();
            try
            {

                using (var context = new ServicesPackageShoppingContext()) //goi toi database
                {
                    listCustomer = context.CustomerManagements.ToList();


                }

            }
            catch (Exception e)
            {


                throw new Exception(e.Message);


            }



            return listCustomer;
        }
        public static CustomerManagement GetCustomerbyId(int id)
        {
            CustomerManagement product = new CustomerManagement();
            try
            {
                using (var context = new ServicesPackageShoppingContext())
                {
                    product = context.CustomerManagements.SingleOrDefault(m => m.CustomerId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }
        public static void AddCustomer(CustomerManagement customer)
        {
            try
            {

                using (var context = new ServicesPackageShoppingContext())
                {

                    context.CustomerManagements.Add(customer);
                    context.SaveChanges();

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static void DeleteCustomer(CustomerManagement customer)
        {
            try
            {
                using (var context = new ServicesPackageShoppingContext())
                {
                    var p1 = context.CustomerManagements.SingleOrDefault(m => m.CustomerId == customer.CustomerId);
                    context.CustomerManagements.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }


        }
        public static void UpdateCustomer(CustomerManagement customer)
        {
            try
            {
                using (var context = new ServicesPackageShoppingContext())
                {
                    context.Entry<CustomerManagement>(customer).State = EntityState.Modified; ;
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
                using (var Context = new ServicesPackageShoppingContext())
                {
                    var temp = Context.CustomerManagements.SingleOrDefault(p => p.Email == email
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
        public static CustomerManagement GetCustomerbyEmail(String email)
        {
            CustomerManagement Customer = new CustomerManagement();
            try
            {
                using (var context = new ServicesPackageShoppingContext())
                {
                    Customer = context.CustomerManagements.SingleOrDefault(m => m.Email == email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Customer;
        }
        public static List<CustomerManagement> SearchByType(String keyword, String Type)
        {

            using (var context = new ServicesPackageShoppingContext())

                if (Type == "Phone")
            {
                try
                {
                    return  context.CustomerManagements.Where(p=> p.Phone.Contains(keyword)).ToList();

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

                    return context.CustomerManagements.Where(p => p.LastName.Contains(keyword)).ToList()
                            .Where(p=>p.FirstName.Contains(keyword)).ToList();  


                }
                catch (FormatException ex)
                {
                    // Log error 
                    throw new Exception($"Invalid keyword for Name: {keyword}", ex);
                    // Throw again or return empty result
                }
            }
            return new List<CustomerManagement>();

        }


    }

    }