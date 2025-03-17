using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransferObject.Security
{
    public class RolePermission
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;

        [Key, Column(Order = 1)]
        [ForeignKey("Permission")]
        public int PermissionId { get; set; }
        public Permission Permission { get; set; } = null!;
    }
}
