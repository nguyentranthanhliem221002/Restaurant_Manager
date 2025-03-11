using System.Collections.Generic;
using TransferObject.TransferObject;

namespace DataLayer.IRepository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders(); // Lấy danh sách tất cả đơn hàng
        Order GetOrderById(int id); // Lấy đơn hàng theo ID
        void AddOrder(Order order); // Thêm đơn hàng mới
        void UpdateOrder(Order order); // Cập nhật đơn hàng
        void DeleteOrder(int id); // Xóa đơn hàng
        decimal GetTotalRevenue(); // Lấy tổng doanh thu từ tất cả đơn hàng
        IEnumerable<Order> GetOrdersByDate(DateTime date); // Lấy danh sách đơn hàng theo ngày
    }
}
