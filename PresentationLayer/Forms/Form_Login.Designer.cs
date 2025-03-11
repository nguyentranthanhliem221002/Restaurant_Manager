namespace PresentationLayer
{
    partial class frm_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_login_title = new Label();
            panel_login = new Panel();
            lb_login_user = new Label();
            txt_login_user = new TextBox();
            txt_login_password = new TextBox();
            lb_login_password = new Label();
            btn_login_submit = new Button();
            checkBox1 = new CheckBox();
            linkLabel_login_toRegister = new LinkLabel();
            SuspendLayout();
            // 
            // lb_login_title
            // 
            lb_login_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_login_title.Location = new Point(733, 95);
            lb_login_title.Name = "lb_login_title";
            lb_login_title.Size = new Size(260, 42);
            lb_login_title.TabIndex = 0;
            lb_login_title.Text = "Đăng nhập";
            lb_login_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_login
            // 
            panel_login.BackColor = Color.Turquoise;
            panel_login.Location = new Point(-1, 0);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(460, 648);
            panel_login.TabIndex = 1;
            // 
            // lb_login_user
            // 
            lb_login_user.Location = new Point(547, 192);
            lb_login_user.Name = "lb_login_user";
            lb_login_user.Size = new Size(122, 28);
            lb_login_user.TabIndex = 2;
            lb_login_user.Text = "Tên đăng nhập :";
            lb_login_user.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_login_user
            // 
            txt_login_user.Location = new Point(675, 192);
            txt_login_user.Name = "txt_login_user";
            txt_login_user.Size = new Size(346, 27);
            txt_login_user.TabIndex = 3;
            // 
            // txt_login_password
            // 
            txt_login_password.Location = new Point(675, 294);
            txt_login_password.Name = "txt_login_password";
            txt_login_password.PasswordChar = 'o';
            txt_login_password.Size = new Size(346, 27);
            txt_login_password.TabIndex = 5;
            // 
            // lb_login_password
            // 
            lb_login_password.Location = new Point(547, 294);
            lb_login_password.Name = "lb_login_password";
            lb_login_password.Size = new Size(122, 28);
            lb_login_password.TabIndex = 4;
            lb_login_password.Text = "Mật khẩu :";
            lb_login_password.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_login_submit
            // 
            btn_login_submit.BackColor = Color.SpringGreen;
            btn_login_submit.ForeColor = Color.White;
            btn_login_submit.Location = new Point(675, 456);
            btn_login_submit.Name = "btn_login_submit";
            btn_login_submit.Size = new Size(346, 54);
            btn_login_submit.TabIndex = 6;
            btn_login_submit.Text = "Đăng nhập";
            btn_login_submit.UseVisualStyleBackColor = false;
            btn_login_submit.Click += btn_login_submit_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(675, 349);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Nhớ tài khoản";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel_login_toRegister
            // 
            linkLabel_login_toRegister.AutoSize = true;
            linkLabel_login_toRegister.Location = new Point(945, 350);
            linkLabel_login_toRegister.Name = "linkLabel_login_toRegister";
            linkLabel_login_toRegister.Size = new Size(63, 20);
            linkLabel_login_toRegister.TabIndex = 8;
            linkLabel_login_toRegister.TabStop = true;
            linkLabel_login_toRegister.Text = "Đăng ký";
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 645);
            Controls.Add(linkLabel_login_toRegister);
            Controls.Add(checkBox1);
            Controls.Add(btn_login_submit);
            Controls.Add(txt_login_password);
            Controls.Add(lb_login_password);
            Controls.Add(txt_login_user);
            Controls.Add(lb_login_user);
            Controls.Add(panel_login);
            Controls.Add(lb_login_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_login_title;
        private Panel panel_login;
        private Label lb_login_user;
        private TextBox txt_login_user;
        private TextBox txt_login_password;
        private Label lb_login_password;
        private Button btn_login_submit;
        private CheckBox checkBox1;
        private LinkLabel linkLabel_login_toRegister;
    }
}