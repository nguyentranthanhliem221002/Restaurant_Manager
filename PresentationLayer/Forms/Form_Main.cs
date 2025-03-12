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
        private readonly string _userRole;
        private Form currentFormChild; // Giữ form con hiện tại

        public frm_main(IServiceProvider serviceProvider, string userRole)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userRole = userRole;

            this.Load += frm_main_Load;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            ApplyRolePermissions();
        }

        // Ẩn nút dựa trên vai trò user
        private void ApplyRolePermissions()
        {
            btn_foods_manager.Visible = _userRole != "Employee";
            btn_employees_manager.Visible = _userRole != "Employee";
        }

        // Mở form con trong panel_container
        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            panel_container.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_container.Controls.Clear(); // Xóa form cũ trước khi thêm form mới
            panel_container.Controls.Add(childForm);
            panel_container.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_tables_Click(object sender, EventArgs e)
        {
            var frmTablesManager = _serviceProvider.GetRequiredService<frm_tables_manager>();
            OpenChildForm(frmTablesManager);
        }

        private void btn_customers_manager_Click(object sender, EventArgs e)
        {
            var frmCustomersManager = _serviceProvider.GetRequiredService<frm_customers_manager>();
            OpenChildForm(frmCustomersManager);
        }

        private void btn_foods_manager_Click(object sender, EventArgs e)
        {
            var frmFoodsManager = _serviceProvider.GetRequiredService<frm_foods_manager>();
            OpenChildForm(frmFoodsManager);
        }

        private void btn_employees_manager_Click(object sender, EventArgs e)
        {
            var frmEmployeesManager = _serviceProvider.GetRequiredService<frm_employees_manager>();
            OpenChildForm(frmEmployeesManager);
        }

        private void btn_order_Click(object sender, EventArgs e)
        {

        }

        //// Quản lý món ăn
        //private void btn_foods_manager_Click(object sender, EventArgs e)
        //{
        //var frmFoodsManager = _serviceProvider.GetRequiredService<frm_foods_manager>();
        //OpenChildForm(frmFoodsManager);
        //}

        //// Quản lý bàn
        //private void btn_tables_Click(object sender, EventArgs e)
        //{
        //var frmTablesManager = _serviceProvider.GetRequiredService<frm_tables_manager>();
        //OpenChildForm(frmTablesManager);
        //}

        //// Quản lý nhân viên
        //private void btn_employees_manager_Click(object sender, EventArgs e)
        //{
        //var frmEmployeesManager = _serviceProvider.GetRequiredService<frm_employees_manager>();
        //OpenChildForm(frmEmployeesManager);
        //}

        //// Quản lý khách hàng (nếu có)
        //private void btn_customers_manager_Click(object sender, EventArgs e)
        //{
        //var frmCustomersManager = _serviceProvider.GetRequiredService<frm_customers_manager>();
        //OpenChildForm(frmCustomersManager);
        //}

        // Thoát ứng dụng
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult cmd = MessageBox.Show("Bạn có muốn thoát phần mềm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cmd == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm_login = new frm_login(_serviceProvider) { Owner = this };

            frm_login.FormClosed += (s, args) => this.Show();
            frm_login.ShowDialog();
        }
    }
}
