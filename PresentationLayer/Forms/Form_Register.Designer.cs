namespace PresentationLayer
{
    partial class frm_register
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
            linkLabel_register_toLogin = new LinkLabel();
            btn_login_submit = new Button();
            txt_register_password = new TextBox();
            lb_register_password = new Label();
            txt_register_user = new TextBox();
            lb_register_user = new Label();
            panel_register = new Panel();
            lb_register_title = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel_register_toLogin
            // 
            linkLabel_register_toLogin.AutoSize = true;
            linkLabel_register_toLogin.Location = new Point(846, 474);
            linkLabel_register_toLogin.Name = "linkLabel_register_toLogin";
            linkLabel_register_toLogin.Size = new Size(176, 20);
            linkLabel_register_toLogin.TabIndex = 17;
            linkLabel_register_toLogin.TabStop = true;
            linkLabel_register_toLogin.Text = "Quay về trang đăng nhập";
            linkLabel_register_toLogin.LinkClicked += linkLabel_register_toLogin_LinkClicked;
            // 
            // btn_login_submit
            // 
            btn_login_submit.BackColor = Color.SpringGreen;
            btn_login_submit.ForeColor = Color.White;
            btn_login_submit.Location = new Point(676, 513);
            btn_login_submit.Name = "btn_login_submit";
            btn_login_submit.Size = new Size(346, 54);
            btn_login_submit.TabIndex = 15;
            btn_login_submit.Text = "Đăng nhập";
            btn_login_submit.UseVisualStyleBackColor = false;
            // 
            // txt_register_password
            // 
            txt_register_password.Location = new Point(676, 297);
            txt_register_password.Name = "txt_register_password";
            txt_register_password.PasswordChar = 'o';
            txt_register_password.Size = new Size(346, 27);
            txt_register_password.TabIndex = 14;
            // 
            // lb_register_password
            // 
            lb_register_password.Location = new Point(513, 297);
            lb_register_password.Name = "lb_register_password";
            lb_register_password.Size = new Size(157, 28);
            lb_register_password.TabIndex = 13;
            lb_register_password.Text = "Mật khẩu :";
            lb_register_password.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_register_user
            // 
            txt_register_user.Location = new Point(676, 192);
            txt_register_user.Name = "txt_register_user";
            txt_register_user.Size = new Size(346, 27);
            txt_register_user.TabIndex = 12;
            // 
            // lb_register_user
            // 
            lb_register_user.Location = new Point(513, 191);
            lb_register_user.Name = "lb_register_user";
            lb_register_user.Size = new Size(157, 28);
            lb_register_user.TabIndex = 11;
            lb_register_user.Text = "Tên người dùng :";
            lb_register_user.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_register
            // 
            panel_register.BackColor = Color.Turquoise;
            panel_register.Location = new Point(0, 0);
            panel_register.Name = "panel_register";
            panel_register.Size = new Size(460, 648);
            panel_register.TabIndex = 10;
            // 
            // lb_register_title
            // 
            lb_register_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_register_title.Location = new Point(734, 95);
            lb_register_title.Name = "lb_register_title";
            lb_register_title.Size = new Size(260, 42);
            lb_register_title.TabIndex = 9;
            lb_register_title.Text = "Đăng ký";
            lb_register_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(676, 420);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = 'o';
            textBox1.Size = new Size(346, 27);
            textBox1.TabIndex = 19;
            // 
            // label1
            // 
            label1.Location = new Point(513, 420);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 18;
            label1.Text = "Nhập lại mật khẩu :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frm_register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 645);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(linkLabel_register_toLogin);
            Controls.Add(btn_login_submit);
            Controls.Add(txt_register_password);
            Controls.Add(lb_register_password);
            Controls.Add(txt_register_user);
            Controls.Add(lb_register_user);
            Controls.Add(panel_register);
            Controls.Add(lb_register_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang đăng ký";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel_register_toLogin;
        private CheckBox checkBox1;
        private Button btn_login_submit;
        private TextBox txt_register_password;
        private Label lb_register_password;
        private TextBox txt_register_user;
        private Label lb_register_user;
        private Panel panel_register;
        private Label lb_register_title;
        private TextBox textBox1;
        private Label label1;
    }
}