using System;
using System.Linq;
using System.Windows.Forms;
using DataLayer;
using TransferObject.Security;
using Microsoft.EntityFrameworkCore;
using BusinessLayer.Service;
using PresentationLayer.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace PresentationLayer
{
    public partial class frm_login : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly TableService _tableService;
        private readonly FoodService _foodService;
        private readonly CategoryService _categoryService;
        private readonly EmployeeService _employeeService;
        private readonly IServiceProvider _serviceProvider;

        public frm_login(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _context = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            _tableService = _serviceProvider.GetRequiredService<TableService>();
            _foodService = _serviceProvider.GetRequiredService<FoodService>();
            _categoryService = _serviceProvider.GetRequiredService<CategoryService>();
            _employeeService = _serviceProvider.GetRequiredService<EmployeeService>();
        }


        private void btn_login_submit_Click(object sender, EventArgs e)
        {
            string username = txt_login_user.Text.Trim();
            string password = txt_login_password.Text.Trim();

            User user = AuthenticateUser(username, password);

            if (user != null)
            {
                MessageBox.Show($"Đăng nhập thành công! Chào {user.UserName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string userRole = user.UserRoles.FirstOrDefault()?.Role?.Name ?? "User";

                this.Hide();
                var mainForm = new frm_main(_serviceProvider, userRole);
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Kiểm tra lại tài khoản và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private User AuthenticateUser(string username, string password)
        {
            return _context.Users
                           .Include(u => u.UserRoles)
                           .ThenInclude(ur => ur.Role)
                           .FirstOrDefault(u => u.UserName == username && u.PasswordHash == password);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult cmd = MessageBox.Show("Bạn có muốn thoát phần mềm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cmd == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel_login_toRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_register registerForm = new frm_register(_serviceProvider) { Owner = this };
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.ShowDialog();
        }
    }
}
