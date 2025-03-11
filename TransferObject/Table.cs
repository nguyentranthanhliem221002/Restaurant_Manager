using System.ComponentModel.DataAnnotations;

namespace TransferObject
{
    public class Table
    {
        public Table() { }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public TableStatus Status { get; set; } // Trạng thái bàn (Enum)
        public List<Order> Orders { get; set; } = new List<Order>();
    }

    // Enum để định nghĩa trạng thái của bàn
        public enum TableStatus
        {
            Available,   // Bàn trống
            Occupied,    // Đang có khách
            Reserved     // Đã được đặt trước
        }
}
