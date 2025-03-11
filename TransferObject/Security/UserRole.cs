using System.ComponentModel.DataAnnotations.Schema;

namespace TransferObject.Security
{
    public class UserRole
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
    }
}
