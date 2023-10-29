using BussinenssObject.Models;

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
        public static List<Order> GetOrders()
        {

            List<Order> listOrder = new List<Order>();
            try
            {
                using (var context = new StudentHouseMembershipContext()) //goi toi database
                {
                    listOrder = context.Orders.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrder;
        }
    
        public static void DeleteOrder(Order order)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    var p1 = context.Orders.SingleOrDefault(m => m.OrderId == order.OrderId);
                    context.Orders.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /*  public IEnumerable<Order> FilterOrderByServiceName(string serviceName, IEnumerable<Order> searchList)
          {
              using (var context = new StudentHouseMembershipContext())
              {
                  IQueryable<Order> query = context.Orders; // OrderManagement(s) ?

                  if (!serviceName.Equals("Ordered Services"))
                  {
                      query = query.Where(order => order.ServiceName == serviceName);
                  }

                  return query.ToList();
              }
          }*/


        public static void AddOrder(OrderDetail order)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {

                    context.OrderDetails.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
