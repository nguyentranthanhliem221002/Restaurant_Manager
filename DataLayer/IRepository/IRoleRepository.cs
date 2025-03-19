using System.Collections.Generic;
using TransferObject.Security; // Import Model Role

namespace DataLayer.IRepository
{
    public interface IRoleRepository
    {
        IQueryable<Role> GetAllRoles(); // Lấy danh sách Role
        Role GetRoleById(int id); // Lấy Role theo ID
        void AddRole(Role role); // Thêm mới Role
        void UpdateRole(Role role); // Cập nhật Role
        void DeleteRole(int id); // Xóa Role theo ID
    }
}
