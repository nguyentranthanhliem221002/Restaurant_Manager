using DataLayer.IRepository;
using System.Collections.Generic;
using TransferObject.TransferObject;

namespace BusinessLayer.Service
{
    public class OrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return _orderDetailRepository.GetAllOrderDetails();
        }

        public IEnumerable<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            return _orderDetailRepository.GetOrderDetailsByOrderId(orderId);
        }

        public OrderDetail GetOrderDetailById(int id)
        {
            return _orderDetailRepository.GetOrderDetailById(id);
        }

        public decimal GetTotalPriceByOrderId(int orderId)
        {
            return _orderDetailRepository.GetTotalPriceByOrderId(orderId);
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailRepository.AddOrderDetail(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailRepository.UpdateOrderDetail(orderDetail);
        }

        public void DeleteOrderDetail(int id)
        {
            _orderDetailRepository.DeleteOrderDetail(id);
        }
    }
}
