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
        public int CheckOrderId(Order order)
        {

            if (order != null && order.Status == "paid")
            {
                // Đánh dấu đơn đặt hàng là đã thanh toán
                // order.status = true;

                // Tạo một orderId mới cho khách hàng
                order.OrderId = GenerateNewOrderId(); // Hãy thay thế GenerateNewOrderId() bằng cách tạo mã orderId theo quy tắc của bạn.

                // Lưu thay đổi vào cơ sở dữ liệu hoặc hệ thống lưu trữ nếu cần


                return order.OrderId; // Trả về true để chỉ ra rằng trạng thái đã được kiểm tra và orderId đã được cập nhật.
            }
            else
            {

                int existingOrderId = GetExistingOrderIdForCustomer(order.CustomerId);
                return existingOrderId;

            }


        }

        private int GetExistingOrderIdForCustomer(int customerId)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    var p1 = context.Orders.SingleOrDefault(p => p.CustomerId == customerId);
                    if (p1 != null)
                    {
                        return p1.OrderId;
                    }
                    else
                    {
                        throw new Exception("can not find ");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //
        private int LastOrderId = GetOrders().Count();


        private int GenerateNewOrderId()
        {
            int newOrderId = LastOrderId + 1;
            return newOrderId;
        }
        //

       /* public Boolean CheckExistServicesID(OrderDetail order, int OrderId)
        {
            try
            {
                List<OrderDetail> getOrder = GetOrderDetails(OrderId);



                using (var context = new StudentHouseMembershipContext())
                {

                }


            }
            catch
            {


            }

        }*/

        public static void AddOrder(OrderDetail order, int productId)
        {

            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    Boolean Checkexist;

                    Checkexist = context.OrderDetails.Any(o => o.OrderId == order.OrderId && o.ServiceId == productId);

                    if (Checkexist)
                    {
                        context.OrderDetails.Add(order);
                        context.SaveChanges();
                    }
                    else
                    { 
                        throw new Exception("services have been exist at your cart");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<OrderDetail> GetOrderDetails(int OrderId)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    return context.OrderDetails.Where(p => p.OrderId == OrderId).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("can not find ");
            }


        }


        public Boolean removeServicesFromCartById(int ProductId, int OrderId)
        {

            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    OrderDetail p1 = context.OrderDetails.Where(p => p.OrderId == OrderId).ToList()
                    .SingleOrDefault(p => p.ServiceId == ProductId);
                    if (p1 != null)
                    {
                        context.OrderDetails.Remove(p1);
                        context.SaveChanges();
                        return true;

                    }
                    else
                    {
                        return false;

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

    }
}
