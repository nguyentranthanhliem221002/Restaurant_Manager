using System;
using System.Linq;
using System.Windows.Forms;
using BCrypt.Net;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TransferObject.Security;
using TransferObject.TransferObject;

namespace PresentationLayer
{
    public partial class frm_login : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public frm_login(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _context = _serviceProvider.GetRequiredService<ApplicationDbContext>();
        }

        private void btn_login_submit_Click(object sender, EventArgs e)
        {
            string userName = txt_login_user.Text.Trim();
            string password = txt_login_password.Text.Trim();

            Account account = AuthenticateUser(userName, password);

            if (account != null)
            {
                // Gán UserId vào SessionManager
                SessionManager.CurrentUserId = account.Id;

                // Kiểm tra Role nếu là enum
                if (account.Role == UserRole.Admin || account.Role == UserRole.Staff)
                {
                    MessageBox.Show($"Đăng nhập thành công! UserId: {SessionManager.CurrentUserId}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở form chính và truyền Role vào
                    var mainForm = new frm_main(_serviceProvider, account.Role.ToString());
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Account AuthenticateUser(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                return null; // Tránh lỗi nếu đầu vào rỗng
            }

            var account = _context.Accounts
                                  .AsNoTracking() // Tăng hiệu suất, tránh tracking không cần thiết
                                  .FirstOrDefault(a => a.UserName == userName);

            if (account != null && BCrypt.Net.BCrypt.Verify(password, account.PasswordHash))
            {
                return account;
            }

            return null;
        }


        private async void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát phần mềm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
