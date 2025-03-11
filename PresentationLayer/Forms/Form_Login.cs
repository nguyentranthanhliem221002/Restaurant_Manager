using System;
using System.Linq;
using System.Windows.Forms;
using DataLayer; // Import DataLayer chứa ApplicationDbContext
using TransferObject.Security; // Import các model User, Role, UserRole
using Microsoft.EntityFrameworkCore;
using PresentationLayer.Forms;
using BusinessLayer.Service; // Import các Service

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

        public frm_login(ApplicationDbContext context, TableService tableService,
                         FoodService foodService, CategoryService categoryService,
                         EmployeeService employeeService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _tableService = tableService;
            _foodService = foodService;
            _categoryService = categoryService;
            _employeeService = employeeService;
            _serviceProvider = serviceProvider;
        }

        private void btn_login_submit_Click(object sender, EventArgs e)
        {
            string username = txt_login_user.Text.Trim();
            string password = txt_login_password.Text.Trim();

            User user = AuthenticateUser(username, password);

            if (user != null)
            {
                MessageBox.Show($"Đăng nhập thành công! Chào {user.UserName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string userRole = user.UserRoles.Any() ? user.UserRoles.First().Role.Name : "Employee";

                this.Hide();
                var mainForm = new frm_main(_serviceProvider, userRole); // Truyền role vào form chính
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
                           .FirstOrDefault(u => u.UserName == username && u.PasswordHash == password); // Thay thế bằng Hash nếu có
        }

        private void ShowUserForms(User user)
        {
            var roles = user.UserRoles.Select(ur => ur.Role.Name).ToList();

            if (roles.Contains("Admin"))
            {
                // Admin có toàn quyền, mở tất cả các form
                new frm_tables_manager(_tableService).Show();
                new frm_foods_manager(_foodService, _categoryService, _serviceProvider).Show();
                new frm_employees_manager(_employeeService).Show();
                new frm_categories_manager(_categoryService).Show();
            }
            else if (roles.Contains("Employee"))
            {
                // Nhân viên chỉ mở frm_tables_manager
                new frm_tables_manager(_tableService).Show();
            }
        }
    }
}
