using BussinenssObject.Models;
using DAOS;
using Repository.IRepository;

namespace Repository.Repository
{
    public class OrderRepository: IOrderRepository
    {
        public void addOrder(Customer p) => CustomerDAOs.AddCustomer(p);
        public void deleteOrder(Customer p) => CustomerDAOs.DeleteCustomer(p);
        public IEnumerable<OrderManagement> FilterOrderByServiceName(string serviceName, IEnumerable<OrderManagement> searchList) => OrderDAOs.Instance.FilterOrderByServiceName(serviceName, searchList);

    }
}
