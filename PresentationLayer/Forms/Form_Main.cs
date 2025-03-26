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
        private Form currentFormChild;
        private  string _role;

        public frm_main(IServiceProvider serviceProvider, string role)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _role = role;
            SetupPermissions();
            LoadUserRole();
        }
        private void LoadUserRole()
        {
            lb_roles.Text = $"Vai trò: {_role}"; // Gán giá trị vào Label lb_role
        }
        /// <summary>
        /// Phân quyền theo Role (Admin/Staff)
        /// </summary>
        private void SetupPermissions()
        {
            if (_role == "Staff")
            {
                btn_employees_manager.Visible = false;  
                btn_customers_manager.Visible = false;  
                btn_account.Visible = false;           
                btn_foods_manager.Visible = false;
            }
        }

        /// <summary>
        /// Mở form con trong panel_container
        /// </summary>
        /// <param name="childForm">Form con cần mở</param>
        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null && currentFormChild.GetType() == childForm.GetType())
            {
                return; // Nếu đang mở đúng form đó thì không làm gì cả
            }

            currentFormChild?.Close();
            currentFormChild = childForm;

            panel_container.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_container.Controls.Add(childForm);
            panel_container.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_tables_Click(object sender, EventArgs e) =>
            OpenChildForm(_serviceProvider.GetRequiredService<frm_tables_manager>());

        private void btn_customers_manager_Click(object sender, EventArgs e) =>
            OpenChildForm(_serviceProvider.GetRequiredService<frm_customers_manager>());

        private void btn_foods_manager_Click(object sender, EventArgs e) =>
            OpenChildForm(_serviceProvider.GetRequiredService<frm_foods_manager>());

        private void btn_employees_manager_Click(object sender, EventArgs e) =>
            OpenChildForm(_serviceProvider.GetRequiredService<frm_employees_manager>());

        private void btn_order_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đặt hàng chưa được triển khai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát phần mềm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm_login = new frm_login(_serviceProvider) { Owner = this };

            frm_login.FormClosed += (s, args) => this.Show(); // Hiện lại form khi login đóng
            frm_login.ShowDialog();
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng tài khoản chưa được triển khai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
