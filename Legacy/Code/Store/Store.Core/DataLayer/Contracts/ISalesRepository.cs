using System;
using System.Linq;
using System.Threading.Tasks;
using Store.Core.DataLayer.DataContracts;
using Store.Core.EntityLayer.Dbo;
using Store.Core.EntityLayer.Sales;

namespace Store.Core.DataLayer.Contracts
{
    public interface ISalesRepository : IRepository
    {
        IQueryable<Customer> GetCustomers();

        Task<Customer> GetCustomerAsync(Customer entity);

        IQueryable<OrderInfo> GetOrders(short? currencyID = null, int? customerID = null, int? employeeID = null, short? orderStatusID = null, Guid? paymentMethodID = null, int? shipperID = null);

        Task<Order> GetOrderAsync(Order entity);

        Task<OrderDetail> GetOrderDetailAsync(OrderDetail entity);

        IQueryable<Shipper> GetShippers();

        Task<Shipper> GetShipperAsync(Shipper entity);

        IQueryable<OrderStatus> GetOrderStatus();

        Task<OrderStatus> GetOrderStatusAsync(OrderStatus entity);

        IQueryable<Currency> GetCurrencies();

        IQueryable<PaymentMethod> GetPaymentMethods();
    }
}
