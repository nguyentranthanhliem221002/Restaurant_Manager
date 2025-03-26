using System.Collections.Generic;
using TransferObject.TransferObject;

namespace DataLayer.IRepository
{
    public interface IOrderRepository
    {
        IQueryable<Order> GetAllOrders(); // Lấy danh sách tất cả đơn hàng
        Order GetOrderById(int id); // Lấy đơn hàng theo ID
        void AddOrder(Order order); // Thêm đơn hàng mới
        void UpdateOrder(Order order); // Cập nhật đơn hàng
        void DeleteOrder(int id); // Xóa đơn hàng
        IQueryable<Order> GetOrdersByDate(DateTime date); // Lấy danh sách đơn hàng theo ngày
        int SaveOrder(int tableId, int userId, List<OrderDetail> orderDetails);
        IQueryable<OrderDetail> GetOrderDetailsByTableId(int tableId);
        int? GetOrderIdByTableId(int tableId);
        void DeleteOrdersByTableId(int tableId);


    }
}
