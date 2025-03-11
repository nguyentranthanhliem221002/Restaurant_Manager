using System.ComponentModel.DataAnnotations.Schema;

namespace TransferObject.Security
{
    public class RolePermission
    {
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;

        [ForeignKey("Permission")]
        public int PermissionId { get; set; }
        public Permission Permission { get; set; } = null!;
    }
}
