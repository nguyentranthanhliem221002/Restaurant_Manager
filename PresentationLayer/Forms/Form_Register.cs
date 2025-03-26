using System;
using System.Linq;
using System.Windows.Forms;
using BCrypt.Net;
using DataLayer;
using TransferObject.Security;
using Microsoft.Extensions.DependencyInjection;

namespace PresentationLayer
{
    public partial class frm_register : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ApplicationDbContext _context;

        public frm_register(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _context = _serviceProvider.GetRequiredService<ApplicationDbContext>();
        }

        // Sự kiện khi người dùng click vào liên kết quay lại trang đăng nhập
        private void linkLabel_register_toLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); // Đóng frm_register để quay lại frm_login
        }

        // Sự kiện khi người dùng click vào nút đăng ký
        private void btn_register_submit_Click(object sender, EventArgs e)
        {
            string username = txt_register_user.Text.Trim();
            string password = txt_register_password.Text.Trim();
            string confirmPassword = txt_register_password2.Text.Trim();

            // Kiểm tra các ô nhập liệu có trống không
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xác nhận mật khẩu
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem username đã tồn tại chưa
            if (_context.Accounts.Any(a => a.UserName == username))
            {
                MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mã hóa mật khẩu với BCrypt
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            // Tạo tài khoản mới
            var newAccount = new Account
            {
                UserName = username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password), // Mã hóa mật khẩu
                Role = UserRole.Customer, // Đảm bảo bạn gán Role đúng
                UserId = null // Nếu không có UserId, bạn có thể để null
            };
            try
            {
                _context.Accounts.Add(newAccount); // Thêm tài khoản vào cơ sở dữ liệu
                _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form đăng ký và quay lại form đăng nhập
            }
            catch (Exception ex)
            {
                // Kiểm tra inner exception và in ra thông báo lỗi chi tiết
                MessageBox.Show($"Có lỗi xảy ra khi đăng ký: {ex.Message}\nInner Exception: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
