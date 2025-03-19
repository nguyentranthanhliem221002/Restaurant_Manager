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
        public DateTime OrderDate { get; set; } = DateTime.Now; // Mặc định là ngày hiện tại

        [Required]
        public int TableId { get; set; }  // Khóa ngoại để liên kết với bảng Table
        [ForeignKey(nameof(TableId))]
        public Table Table { get; set; } // Liên kết với đối tượng Table

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
