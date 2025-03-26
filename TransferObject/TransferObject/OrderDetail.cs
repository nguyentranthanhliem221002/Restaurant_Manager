using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransferObject.TransferObject
{
    public class OrderDetail
    {
        public OrderDetail() { }

        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order? Order { get; set; }

        [Required]
        public int FoodId { get; set; }

        [ForeignKey("FoodId")]
        public virtual Food? Food { get; set; }  // Thêm quan hệ với bảng Foods

        [Required]
        public string FoodName { get; set; } // Có thể lấy từ Food.Name khi thêm dữ liệu

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,3)")]
        public decimal Price { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,3)")]
        public decimal Total { get; set; }
    }
}
