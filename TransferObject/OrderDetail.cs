using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransferObject
{
    public class OrderDetail
    {
        public OrderDetail() { }
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [Required]
        public int FoodId { get; set; }

        [ForeignKey("FoodId")]
        public Food Food { get; set; }
         
        [Required]
        public int Quality { get; set; } // Số lượng món ăn

        [Required]
        [Column(TypeName = "decimal(10,3)")]
        public decimal Price { get; set; } // Giá của từng món tại thời điểm đặt hàng


    }
}
