using DataLayer.IRepository;
using TransferObject;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Service
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public Order GetOrderById(int id)
        {
            return _orderRepository.GetOrderById(id);
        }

        public void AddOrder(Order order)
        {
            _orderRepository.AddOrder(order);
        }

        public void UpdateOrder(Order order)
        {
            _orderRepository.UpdateOrder(order);
        }

        public void DeleteOrder(int id)
        {
            _orderRepository.DeleteOrder(id);
        }

        public decimal GetTotalRevenue()
        {
            return _orderRepository.GetTotalRevenue();
        }

        public IEnumerable<Order> GetOrdersByDate(DateTime date)
        {
            return _orderRepository.GetOrdersByDate(date);
        }
    }
}
