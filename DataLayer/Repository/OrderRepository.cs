using DataLayer.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TransferObject.TransferObject;

namespace DataLayer.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Order> GetAllOrders() => _context.Orders;

        public Order GetOrderById(int id) => _context.Orders.Find(id);

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            var existingOrder = _context.Orders.Find(order.Id);
            if (existingOrder != null)
            {
                existingOrder.OrderDate = order.OrderDate;
                _context.SaveChanges();
            }
        }

        public void DeleteOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        public IQueryable<Order> GetOrdersByDate(DateTime date) => _context.Orders.Where(o => o.OrderDate.Date == date.Date);
        public int SaveOrder(int tableId, int userId, List<OrderDetail> orderDetails)
        {
            var newOrder = new Order
            {
                TableId = tableId,
                OrderDate = DateTime.Now,
                UserId = userId,
                OrderDetails = orderDetails,
                Status = OrderStatus.Pending
            };

            _context.Orders.Add(newOrder);
            _context.SaveChanges();

            return newOrder.Id;
        }
        public IQueryable<OrderDetail> GetOrderDetailsByTableId(int tableId)
        {
            return _context.OrderDetails
                .Include(od => od.Order)
                .Where(od => od.Order.TableId == tableId && od.Order.Status == OrderStatus.Pending)
                .AsNoTracking();
        }
        public int? GetOrderIdByTableId(int tableId)
        {
            return _context.Orders
                .Where(o => o.TableId == tableId && o.Status == OrderStatus.Pending)
                .OrderByDescending(o => o.OrderDate)
                .Select(o => o.Id)
                .FirstOrDefault();
        }
        public void DeleteOrdersByTableId(int tableId)
        {
            var orders = _context.Orders
                .Include(o => o.OrderDetails)
                .Where(o => o.TableId == tableId)
                .ToList();

            if (orders.Any())
            {
                foreach (var order in orders)
                {
                    _context.OrderDetails.RemoveRange(order.OrderDetails); // Xóa chi tiết đơn hàng trước
                    _context.Orders.Remove(order); // Xóa đơn hàng
                }

                _context.SaveChanges();
            }
        }
    }
}
