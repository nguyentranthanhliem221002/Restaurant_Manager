using System.ComponentModel.DataAnnotations;

namespace TransferObject.Security
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        // Quan hệ nhiều-nhiều với Permission
        [Required]
        public List<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
