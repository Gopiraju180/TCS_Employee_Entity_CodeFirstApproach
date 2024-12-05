using TCS_Employee_Entity_CodeFirstApproach.Dtos;
using TCS_Employee_Entity_CodeFirstApproach.Interfaces;

namespace TCS_Employee_Entity_CodeFirstApproach.Services
{
    public class OrdersService : IOrdersService
    {
        IOrdersRepository _ordersRepository;
        public OrdersService(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;  
        }
        public async Task<int> AddOrder(OrdersDto orderdetail)
        {
            Orders ors = new Orders();
            ors.orderid = orderdetail.orderid;
            ors.ordername = orderdetail.ordername;
            ors.orderlocation = orderdetail.orderlocation;
            var res = await _ordersRepository.AddOrder(ors);
            return res;
        }

        public async Task<bool> DeleteOrderById(int orderid)
        {
            await _ordersRepository.DeleteOrderById(orderid);
            return true;
        }

        public async Task<OrdersDto> GetOrderById(int orderid)
        {
            var res = await _ordersRepository.GetOrderById(orderid);
            OrdersDto orsDto = new OrdersDto();
            orsDto.orderid = res.orderid;
            orsDto.ordername = res.ordername;
            orsDto.orderlocation = res.orderlocation;
            return orsDto;
        }

        public async Task<List<OrdersDto>> GetOrders()
        {
            List<OrdersDto> lisorsDto = new List<OrdersDto>();
            var res = await _ordersRepository.GetOrders();
            foreach (Orders ors in res)
            {
                OrdersDto orsDto = new OrdersDto();
                orsDto.orderid = ors.orderid;
                orsDto.ordername = ors.ordername;
                orsDto.orderlocation = ors.orderlocation;
                lisorsDto.Add(orsDto);

            }
            return lisorsDto;
        }

        public async Task<bool> UpdateOrder(OrdersDto orderdetail)
        {
            Orders ors = new Orders();
            ors.orderid = orderdetail.orderid;
            ors.ordername = orderdetail.ordername;
            ors.orderlocation = orderdetail.orderlocation;
            await _ordersRepository.UpdateOrder(ors);
            return true;
        }
    }
}
