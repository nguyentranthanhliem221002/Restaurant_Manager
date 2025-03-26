using System.ComponentModel.DataAnnotations;
using TransferObject.Security;

namespace TransferObject.TransferObject
{
    public class Employee : User
    {
        public Employee() { }


        [Required]
        public DateTime DateOfJoining { get; set; }
        [Required]
        public string Role { get; set; } = string.Empty; // "Admin", "Staff", "Customer"


    }
}
