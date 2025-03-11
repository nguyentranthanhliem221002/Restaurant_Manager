using System.ComponentModel.DataAnnotations;

namespace TransferObject
{
    public class Employee
    {
        public Employee() { }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Số điện thoại phải có 10 chữ số.")]
        public string? Phone { get; set; }

        [Required]
        public DateTime DateOfJoining { get; set; }
         
    }
}
