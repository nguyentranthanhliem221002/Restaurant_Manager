using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Forms;

namespace PresentationLayer;

public partial class frm_main : Form
{
    private readonly IServiceProvider _serviceProvider;  // Nhận từ DI

    public frm_main(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
    }

    private void btn_foods_manager_Click(object sender, EventArgs e)
    {
        this.Hide();
        var frmFoodsManager = _serviceProvider.GetRequiredService<frm_foods_manager>();
        frmFoodsManager.ShowDialog();  // Hiển thị form quản lý món ăn
        this.Show();  // Hiển thị lại form chính khi frm_foods_manager đóng
    }



    private void Form_Main_Load(object sender, EventArgs e)
    {

    }

    private void btn_exit_Click(object sender, EventArgs e)
    {
        DialogResult cmd = MessageBox.Show("Bạn có muốn thoát phần mềm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (cmd == DialogResult.Yes)
        {
            Application.Exit();
        }
    }



    private void btn_login_Click(object sender, EventArgs e)
    {
        this.Hide();
        frm_login frm_Login = new frm_login();
        frm_Login.Show();
    }

    private void btn_tables_Click(object sender, EventArgs e)
    {
        this.Hide();
        var frmTablesManager = _serviceProvider.GetRequiredService<frm_tables_manager>();
        frmTablesManager.ShowDialog(); 
        this.Show();
    }

    private void btn_employees_manager_Click(object sender, EventArgs e)
    {
        this.Hide();
        var frmEmployeesManager = _serviceProvider.GetRequiredService<frm_employees_manager>();
        frmEmployeesManager.ShowDialog();  
        this.Show(); 
    }
}
