
using Microsoft.EntityFrameworkCore;

namespace TCS_Employee_Entity_CodeFirstApproach.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly EmployeeContext _employeeContext;
        public OrdersRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public async Task<int> AddOrder(Orders orderdetail)
        {
            await _employeeContext.orderss.AddAsync(orderdetail);//add the record by using addasync
            _employeeContext.SaveChanges();//it will commit/save the data perminently in table
            return 1;
        }

        public async Task<bool> DeleteOrderById(int orderid)
        {
            Orders rm = _employeeContext.orderss.SingleOrDefault(e => e.orderid == orderid);
            if (rm != null)
            {//Here Remove() method is used for removing the data from database.

                _employeeContext.orderss.Remove(rm);
                _employeeContext.SaveChanges();
                return true;
            }
            else return false;
        }

        public async Task<Orders> GetOrderById(int orderid)
        {
            var rm = await _employeeContext.orderss.Where(e => e.orderid == orderid).FirstOrDefaultAsync();

            if (rm == null)
                return null;
            else
                return rm;
        }

        public async Task<List<Orders>> GetOrders()
        {
            var result = _employeeContext.orderss.ToList();
            if (result.Count == 0)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public async Task<bool> UpdateOrder(Orders orderdetail)
        {
            _employeeContext.Update(orderdetail);
            await _employeeContext.SaveChangesAsync();
            return true;
        }
    }
}
