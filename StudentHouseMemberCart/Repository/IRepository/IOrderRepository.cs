using BussinenssObject.Models;

namespace Repository.IRepository
{
    public interface IOrderRepository
    {
        public void deleteOrder(Customer p);
        public void addOrder(Customer p);
        public IEnumerable<Order> FilterOrderByServiceName(string serviceName, IEnumerable<Order> searchList);
    }
}
