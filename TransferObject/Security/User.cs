using System.ComponentModel.DataAnnotations;

namespace TransferObject.Security
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        // Quan hệ nhiều-nhiều với Role
        [Required]
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
