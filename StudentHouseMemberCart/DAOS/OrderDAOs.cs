using BussinenssObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOS
{
    public class OrderDAOs
    {
        private static OrderDAOs instance;
        private static object instanceLock = new object();
        public static OrderDAOs Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAOs();
                }
                return instance;
            }
        }
        public static List<OrderManagement> GetOrders()
        {

            List<OrderManagement> listOrder = new List<OrderManagement>();
            try
            {
                using (var context = new ServicesPackageShoppingContext()) //goi toi database
                {
                    listOrder = context.OrderManagements.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrder;
        }
        public static void AddOrder(OrderManagement order)
        {
            try
            {
                using (var context = new ServicesPackageShoppingContext())
                {

                    context.OrderManagements.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteOrder(OrderManagement order)
        {
            try
            {
                using (var context = new ServicesPackageShoppingContext())
                {
                    var p1 = context.OrderManagements.SingleOrDefault(m => m.OrderId == order.OrderId);
                    context.OrderManagements.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<OrderManagement> FilterOrderByServiceName(string serviceName, IEnumerable<OrderManagement> searchList)
        {
            using (var context = new ServicesPackageShoppingContext())
            {
                IQueryable<OrderManagement> query = context.OrderManagements; // OrderManagement(s) ?

                if (!serviceName.Equals("Ordered Services"))
                {
                    query = query.Where(order => order.ServiceName == serviceName);
                }

                return query.ToList();
            }
        }

    }
}
