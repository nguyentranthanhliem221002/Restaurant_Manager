using DataLayer.IRepository;
using TransferObject;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả đơn hàng
        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        // Lấy đơn hàng theo ID
        public Order GetOrderById(int id)
        {
            return _context.Orders.Find(id);
        }

        // Thêm đơn hàng mới
        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        // Cập nhật đơn hàng
        public void UpdateOrder(Order order)
        {
            var existingOrder = _context.Orders.Find(order.Id);
            if (existingOrder != null)
            {
                existingOrder.Name = order.Name;
                existingOrder.OrderDate = order.OrderDate;
                existingOrder.Total = order.Total;
                _context.SaveChanges();
            }
        }

        // Xóa đơn hàng
        public void DeleteOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        // Lấy tổng doanh thu từ tất cả đơn hàng
        public decimal GetTotalRevenue()
        {
            return _context.Orders.Sum(o => o.Total);
        }

        // Lấy danh sách đơn hàng theo ngày
        public IEnumerable<Order> GetOrdersByDate(DateTime date)
        {
            return _context.Orders.Where(o => o.OrderDate.Date == date.Date).ToList();
        }

    }
}
