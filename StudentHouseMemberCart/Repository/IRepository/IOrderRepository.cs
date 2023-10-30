using BussinenssObject;

namespace Repository.IRepository
{
    public interface IOrderRepository
    {

        public void deleteOrder(Order p);
        public void addOrder(Order p);
        public IEnumerable<Order> FilterOrderByServiceName(string serviceName, IEnumerable<Order> searchList);
       // cai nay check de generate ra OrderId moi  nếu thanh toán rồi thì tạo ra orderId mới cho người dùng đó 
        public int CheckOrderId(Order p);
        //return OrderId by CustomerID 
        public int GetExistingOrderIdForCustomer(int customerId);
        // Add serviceId vao OrderDetail
         public void Addorder(OrderDetail p, int ProductId);

        //Return OrderDetail  by OrderId
        public List<OrderDetail> GetOrderDetails(int orderId);

        //Remove 
        public Boolean removeServicesFromCartById(int ProductId, int OrderId);



    }
}
