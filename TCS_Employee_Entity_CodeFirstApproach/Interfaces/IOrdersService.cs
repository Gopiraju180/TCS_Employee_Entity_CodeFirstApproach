using TCS_Employee_Entity_CodeFirstApproach.Dtos;

namespace TCS_Employee_Entity_CodeFirstApproach
{
    public interface IOrdersService
    {
        Task<List<OrdersDto>> GetOrders();
        Task<OrdersDto> GetOrderById(int orderid);
        Task<int> AddOrder(OrdersDto orderdetail);
        Task<bool> DeleteOrderById(int orderid);
        Task<bool> UpdateOrder(OrdersDto orderdetail);
    }
}
