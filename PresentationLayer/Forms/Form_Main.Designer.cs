namespace PresentationLayer;

partial class frm_main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel_sidebar = new Panel();
        btn_employees_manager = new Button();
        btn_account = new Button();
        btn_order = new Button();
        btn_foods_manager = new Button();
        btn_customers_manager = new Button();
        btn_tables = new Button();
        panel_container = new Panel();
        panel_nav = new Panel();
        lb_main_title = new Label();
        btn_login = new Button();
        btn_exit = new Button();
        panel_sidebar.SuspendLayout();
        panel_nav.SuspendLayout();
        SuspendLayout();
        // 
        // panel_sidebar
        // 
        panel_sidebar.BackColor = Color.Turquoise;
        panel_sidebar.Controls.Add(btn_employees_manager);
        panel_sidebar.Controls.Add(btn_account);
        panel_sidebar.Controls.Add(btn_order);
        panel_sidebar.Controls.Add(btn_foods_manager);
        panel_sidebar.Controls.Add(btn_customers_manager);
        panel_sidebar.Controls.Add(btn_tables);
        panel_sidebar.Location = new Point(0, 76);
        panel_sidebar.Name = "panel_sidebar";
        panel_sidebar.Size = new Size(170, 645);
        panel_sidebar.TabIndex = 0;
        // 
        // btn_employees_manager
        // 
        btn_employees_manager.BackColor = Color.FromArgb(255, 192, 192);
        btn_employees_manager.ForeColor = Color.DimGray;
        btn_employees_manager.Location = new Point(0, 363);
        btn_employees_manager.Name = "btn_employees_manager";
        btn_employees_manager.Size = new Size(170, 45);
        btn_employees_manager.TabIndex = 5;
        btn_employees_manager.Text = "Quản lý nhân viên";
        btn_employees_manager.UseVisualStyleBackColor = false;
        btn_employees_manager.Click += btn_employees_manager_Click;
        // 
        // btn_account
        // 
        btn_account.BackColor = Color.FromArgb(255, 192, 192);
        btn_account.ForeColor = Color.DimGray;
        btn_account.Location = new Point(0, 600);
        btn_account.Name = "btn_account";
        btn_account.Size = new Size(170, 45);
        btn_account.TabIndex = 4;
        btn_account.Text = "Tài khoản";
        btn_account.UseVisualStyleBackColor = false;
        // 
        // btn_order
        // 
        btn_order.BackColor = Color.FromArgb(255, 192, 192);
        btn_order.ForeColor = Color.DimGray;
        btn_order.Location = new Point(0, 483);
        btn_order.Name = "btn_order";
        btn_order.Size = new Size(170, 45);
        btn_order.TabIndex = 3;
        btn_order.Text = "Thống kê";
        btn_order.UseVisualStyleBackColor = false;
        // 
        // btn_foods_manager
        // 
        btn_foods_manager.BackColor = Color.FromArgb(255, 192, 192);
        btn_foods_manager.ForeColor = Color.DimGray;
        btn_foods_manager.Location = new Point(0, 240);
        btn_foods_manager.Name = "btn_foods_manager";
        btn_foods_manager.Size = new Size(170, 45);
        btn_foods_manager.TabIndex = 2;
        btn_foods_manager.Text = "Quản lý món ăn";
        btn_foods_manager.UseVisualStyleBackColor = false;
        btn_foods_manager.Click += btn_foods_manager_Click;
        // 
        // btn_customers_manager
        // 
        btn_customers_manager.BackColor = Color.FromArgb(255, 192, 192);
        btn_customers_manager.ForeColor = Color.DimGray;
        btn_customers_manager.Location = new Point(0, 126);
        btn_customers_manager.Name = "btn_customers_manager";
        btn_customers_manager.Size = new Size(170, 45);
        btn_customers_manager.TabIndex = 1;
        btn_customers_manager.Text = "Quản lý khách hàng";
        btn_customers_manager.UseVisualStyleBackColor = false;
        // 
        // btn_tables
        // 
        btn_tables.BackColor = Color.FromArgb(255, 192, 192);
        btn_tables.ForeColor = Color.DimGray;
        btn_tables.Location = new Point(0, 19);
        btn_tables.Name = "btn_tables";
        btn_tables.Size = new Size(170, 45);
        btn_tables.TabIndex = 0;
        btn_tables.Text = "Sơ đồ bàn ăn";
        btn_tables.UseVisualStyleBackColor = false;
        btn_tables.Click += btn_tables_Click;
        // 
        // panel_container
        // 
        panel_container.BackColor = Color.Transparent;
        panel_container.Location = new Point(170, 76);
        panel_container.Name = "panel_container";
        panel_container.Size = new Size(1178, 645);
        panel_container.TabIndex = 1;
        // 
        // panel_nav
        // 
        panel_nav.BackColor = Color.DarkSlateGray;
        panel_nav.Controls.Add(lb_main_title);
        panel_nav.Controls.Add(btn_login);
        panel_nav.Controls.Add(btn_exit);
        panel_nav.Location = new Point(0, 0);
        panel_nav.Name = "panel_nav";
        panel_nav.Size = new Size(1348, 76);
        panel_nav.TabIndex = 2;
        // 
        // lb_main_title
        // 
        lb_main_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        lb_main_title.ForeColor = Color.White;
        lb_main_title.Location = new Point(513, 15);
        lb_main_title.Name = "lb_main_title";
        lb_main_title.Size = new Size(260, 42);
        lb_main_title.TabIndex = 1;
        lb_main_title.Text = "Quản lý nhà hàng";
        lb_main_title.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btn_login
        // 
        btn_login.Location = new Point(1138, 0);
        btn_login.Name = "btn_login";
        btn_login.Size = new Size(136, 76);
        btn_login.TabIndex = 0;
        btn_login.Text = "Đăng nhập";
        btn_login.UseVisualStyleBackColor = true;
        btn_login.Click += btn_login_Click;
        // 
        // btn_exit
        // 
        btn_exit.Location = new Point(1292, 24);
        btn_exit.Name = "btn_exit";
        btn_exit.Size = new Size(30, 30);
        btn_exit.TabIndex = 0;
        btn_exit.Text = "x";
        btn_exit.UseVisualStyleBackColor = true;
        btn_exit.Click += btn_exit_Click;
        // 
        // frm_main
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1348, 721);
        Controls.Add(panel_nav);
        Controls.Add(panel_container);
        Controls.Add(panel_sidebar);
        FormBorderStyle = FormBorderStyle.None;
        Name = "frm_main";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Trang chủ";
        Load += Form_Main_Load;
        panel_sidebar.ResumeLayout(false);
        panel_nav.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel_sidebar;
    private Panel panel_container;
    private Panel panel_nav;
    private Button btn_exit;
    private Button btn_employees_manager;
    private Button btn_account;
    private Button btn_order;
    private Button btn_foods_manager;
    private Button btn_customers_manager;
    private Button btn_tables;
    private Button btn_login;
    private Label lb_main_title;
}
