using TransferObject;

namespace DataLayer.IRepository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetAllOrderDetails(); // Lấy danh sách chi tiết đơn hàng
        IEnumerable<OrderDetail> GetOrderDetailsByOrderId(int orderId); // Lấy danh sách theo OrderId
        OrderDetail GetOrderDetailById(int id); // Lấy chi tiết đơn hàng theo ID
        decimal GetTotalPriceByOrderId(int orderId); // Lấy tổng tiền của 1 đơn hàng
        void AddOrderDetail(OrderDetail orderDetail); // Thêm chi tiết đơn hàng mới
        void UpdateOrderDetail(OrderDetail orderDetail); // Cập nhật chi tiết đơn hàng
        void DeleteOrderDetail(int id); // Xóa chi tiết đơn hàng
    }
}
