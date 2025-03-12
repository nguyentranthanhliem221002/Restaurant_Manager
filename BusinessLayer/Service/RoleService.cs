using System.Collections.Generic;
using DataLayer.IRepository;
using TransferObject.Security; // Import Model Role

namespace BusinessLayer.Service
{
    public class RoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return _roleRepository.GetAllRoles();
        }

        public Role GetRoleById(int id)
        {
            return _roleRepository.GetRoleById(id);
        }

        public void AddRole(Role role)
        {
            _roleRepository.AddRole(role);
        }

        public void UpdateRole(Role role)
        {
            _roleRepository.UpdateRole(role);
        }

        public void DeleteRole(int id)
        {
            _roleRepository.DeleteRole(id);
        }
    }
}
