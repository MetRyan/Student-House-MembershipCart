using BussinenssObject.Models;

namespace Repository.IRepository
{
    public interface IOrderRepository
    {
        public void deleteOrder(CustomerManagement p);
        public void addOrder(CustomerManagement p);
        public IEnumerable<OrderManagement> FilterOrderByServiceName(string serviceName, IEnumerable<OrderManagement> searchList);
    }
}
