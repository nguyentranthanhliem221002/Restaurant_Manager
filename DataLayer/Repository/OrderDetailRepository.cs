using DataLayer.IRepository;
using TransferObject;

namespace DataLayer.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderDetailRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả chi tiết đơn hàng
        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return _context.OrderDetails.ToList();
        }

        // Lấy danh sách chi tiết đơn hàng theo OrderId
        public IEnumerable<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            return _context.OrderDetails.Where(od => od.OrderId == orderId).ToList();
        }

        // Lấy chi tiết đơn hàng theo Id
        public OrderDetail GetOrderDetailById(int id)
        {
            return _context.OrderDetails.Find(id);
        }

        // Lấy tổng tiền của 1 đơn hàng
        public decimal GetTotalPriceByOrderId(int orderId)
        {
            return _context.OrderDetails
                           .Where(od => od.OrderId == orderId)
                           .Sum(od => od.Price * od.Quality);
        }

        // Thêm chi tiết đơn hàng mới
        public void AddOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }

        // Cập nhật chi tiết đơn hàng
        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            var existingOrderDetail = _context.OrderDetails.Find(orderDetail.Id);
            if (existingOrderDetail != null)
            {
                existingOrderDetail.OrderId = orderDetail.OrderId;
                existingOrderDetail.FoodId = orderDetail.FoodId;
                existingOrderDetail.Quality = orderDetail.Quality;
                existingOrderDetail.Price = orderDetail.Price;
                _context.SaveChanges();
            }
        }

        // Xóa chi tiết đơn hàng
        public void DeleteOrderDetail(int id)
        {
            var orderDetail = _context.OrderDetails.Find(id);
            if (orderDetail != null)
            {
                _context.OrderDetails.Remove(orderDetail);
                _context.SaveChanges();
            }
        }
    }
}
