using BusinessLayer.Service;
using DataLayer;
using TransferObject.Security;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;

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

        private void linkLabel_register_toLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); // Đóng frm_register để quay lại frm_login
        }

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
            if (_context.Users.Any(u => u.UserName == username))
            {
                MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo tài khoản mới
            var newUser = new User
            {
                UserName = username,
                PasswordHash = password // Cần mã hóa mật khẩu thay vì lưu dạng plain text
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đóng form đăng ký và mở lại form đăng nhập
            this.Close();
        }
    }
}
