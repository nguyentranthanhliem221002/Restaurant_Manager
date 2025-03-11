using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransferObject.TransferObject
{
    public class Order
    {
        public Order() { }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }  // Tên đơn hàng hoặc người đặt hàng

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now; // Mặc định là ngày hiện tại

        [Required]
        [Column(TypeName = "decimal(10,3)")]
        public decimal Total { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
