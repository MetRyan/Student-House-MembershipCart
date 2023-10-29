using BussinenssObject.Models;

namespace Repository.IRepository
{
    public interface IOrderRepository
    {
        public void deleteOrder(Order p);
        public void addOrder(Order p);
        public IEnumerable<Order> FilterOrderByServiceName(string serviceName, IEnumerable<Order> searchList);
    }
}
