using BusinessLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TransferObject.Security;
using TransferObject.TransferObject;

namespace PresentationLayer.Forms
{
    public partial class frm_roles_manager : Form
    {
        private readonly RoleService _roleService;

        public frm_roles_manager(RoleService roleService)
        {
            InitializeComponent();
            _roleService = roleService ?? throw new ArgumentNullException(nameof(roleService));
        }

        private void frm_roles_manager_Load(object sender, EventArgs e)
        {
            LoadRoleData();
        }

        private void LoadRoleData()
        {
            var roles = _roleService.GetAllRoles()?.ToList() ?? new List<Role>();
            dgv_listRole.DataSource = roles;
        }

        private void btn_roleAdd_Click(object sender, EventArgs e)
        {
            string roleName = txt_roleName.Text.Trim();

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Vui lòng nhập tên vai trò!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Role role = new Role { Name = roleName };
            _roleService.AddRole(role);
            LoadRoleData();
            MessageBox.Show("Thêm vai trò thành công!", "Thông báo");

            txt_roleName.Clear();
        }

        private void btn_roleDelete_Click(object sender, EventArgs e)
        {
            if (dgv_listRole.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một vai trò để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roleId = (int)dgv_listRole.SelectedRows[0].Cells["Id"].Value;
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa vai trò này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _roleService.DeleteRole(roleId);
                LoadRoleData();
                MessageBox.Show("Xóa vai trò thành công!", "Thông báo");
            }
        }

        private void btn_roleFix_Click(object sender, EventArgs e)
        {
            if (dgv_listRole.SelectedRows.Count > 0)
            {
                int roleId = (int)dgv_listRole.SelectedRows[0].Cells["Id"].Value;
                string roleName = dgv_listRole.SelectedRows[0].Cells["Name"].Value.ToString();

                txt_roleName.Text = roleName;
                btn_roleUpdate.Tag = roleId;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một vai trò để chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_roleUpdate_Click(object sender, EventArgs e)
        {
            if (btn_roleUpdate.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn một vai trò để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_roleName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên vai trò!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int roleId = (int)btn_roleUpdate.Tag;
            string roleName = txt_roleName.Text.Trim();

            Role role = new Role { Id = roleId, Name = roleName };
            _roleService.UpdateRole(role);
            LoadRoleData();
            MessageBox.Show("Cập nhật vai trò thành công!", "Thông báo");

            txt_roleName.Clear();
            btn_roleUpdate.Tag = null;
        }

        private void btn_categorySearch_Click(object sender, EventArgs e)
        {
            string keyword = txt_roles_manager_search.Text.Trim().ToLower();
            var roles = _roleService.GetAllRoles()?.ToList() ?? new List<Role>();

            var searchResult = string.IsNullOrEmpty(keyword)
                ? roles
                : roles.Where(r => r.Name.ToLower().Contains(keyword)).ToList();

            dgv_listRole.DataSource = null;
            dgv_listRole.DataSource = searchResult;
        }
    }
}
