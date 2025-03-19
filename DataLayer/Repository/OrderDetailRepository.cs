using DataLayer.IRepository;
using System.Linq;
using TransferObject.TransferObject;

namespace DataLayer.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderDetailRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<OrderDetail> GetAllOrderDetails() => _context.OrderDetails;

        public IQueryable<OrderDetail> GetOrderDetailsByOrderId(int orderId) => _context.OrderDetails.Where(od => od.OrderId == orderId);

        public OrderDetail GetOrderDetailById(int id) => _context.OrderDetails.Find(id);

        public decimal GetTotalPriceByOrderId(int orderId)
        {
            return _context.OrderDetails
                           .Where(od => od.OrderId == orderId)
                           .Sum(od => od.Price * od.Quantity);
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            var existingOrderDetail = _context.OrderDetails.Find(orderDetail.Id);
            if (existingOrderDetail != null)
            {
                existingOrderDetail.OrderId = orderDetail.OrderId;
                existingOrderDetail.FoodId = orderDetail.FoodId;
                existingOrderDetail.Quantity = orderDetail.Quantity;
                existingOrderDetail.Price = orderDetail.Price;
                _context.SaveChanges();
            }
        }

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
