using DataLayer.IRepository;
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
    }
}
