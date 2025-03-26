using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransferObject.Security;

namespace TransferObject.TransferObject
{
    public enum OrderStatus
    {
        Pending,
        Completed,
        Canceled
    }

    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Required]
        public int TableId { get; set; }

        [ForeignKey("TableId")]
        public virtual Table? Table { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [Required]
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; } 

    }
}
