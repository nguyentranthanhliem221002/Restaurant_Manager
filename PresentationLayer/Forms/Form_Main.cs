using BusinessLayer.Service;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Forms;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frm_main : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly string _userRole;  // Thêm biến để lưu vai trò user

        public frm_main(IServiceProvider serviceProvider, string userRole)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userRole = userRole; // Gán vai trò khi form được tạo

            this.Load += frm_main_Load; // Đảm bảo sự kiện Load được gọi

        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            ApplyRolePermissions(); // Áp dụng quyền khi form load
        }

        private void ApplyRolePermissions()
        {

            if (_userRole == "Employee")
            {
                btn_foods_manager.Visible = false;  // Ẩn hẳn nút quản lý món ăn
                btn_employees_manager.Visible = false; // Ẩn quản lý nhân viên
            }
        }

        private void btn_foods_manager_Click(object sender, EventArgs e)
        {
            var frmFoodsManager = _serviceProvider.GetRequiredService<frm_foods_manager>();
            frmFoodsManager.ShowDialog();
        }

        private void btn_tables_Click(object sender, EventArgs e)
        {
            var frmTablesManager = _serviceProvider.GetRequiredService<frm_tables_manager>();
            frmTablesManager.ShowDialog();
        }

        private void btn_employees_manager_Click(object sender, EventArgs e)
        {
            var frmEmployeesManager = _serviceProvider.GetRequiredService<frm_employees_manager>();
            frmEmployeesManager.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult cmd = MessageBox.Show("Bạn có muốn thoát phần mềm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cmd == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

     

        private void btn_customers_manager_Click(object sender, EventArgs e)
        {

        }
    }
}
