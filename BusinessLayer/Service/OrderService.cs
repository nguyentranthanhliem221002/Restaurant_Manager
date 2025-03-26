using DataLayer.IRepository;
using System;
using System.Collections.Generic;
using TransferObject.TransferObject;

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



        public IEnumerable<Order> GetOrdersByDate(DateTime date)
        {
            return _orderRepository.GetOrdersByDate(date);
        }
        public int SaveOrder(int tableId, int userId, List<OrderDetail> orderDetails)
        {
            return _orderRepository.SaveOrder(tableId,userId, orderDetails);
        }

        public IQueryable<OrderDetail> GetOrderDetailsByTableId(int tableId)
        {
            return _orderRepository.GetOrderDetailsByTableId(tableId);
        }
        public int? GetOrderIdByTableId(int tableId)
        {
            return _orderRepository.GetOrderIdByTableId(tableId);
        }
        public void DeleteOrdersByTableId(int tableId)
        {
            _orderRepository.DeleteOrdersByTableId(tableId);
        }
    }
}
