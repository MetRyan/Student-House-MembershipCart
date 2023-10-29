using BussinenssObject.Models;
using DAOS;
using Repository.IRepository;

namespace Repository.Repository
{
    public class OrderRepository: IOrderRepository
    {
        public void addOrder(Order p) => CustomerDAOs.AddCustomer(p);
        public void deleteOrder(Order p) => CustomerDAOs.DeleteCustomer(p);
        public IEnumerable<Order> FilterOrderByServiceName(string serviceName, IEnumerable<Order> searchList) => OrderDAOs.Instance.FilterOrderByServiceName(serviceName, searchList);

    }
}
