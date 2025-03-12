namespace PresentationLayer.Forms
{
    partial class frm_roles_manager
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
            groupBox_listRole = new GroupBox();
            dgv_listRole = new DataGridView();
            lb_roles_manager_search = new Label();
            txt_roles_manager_search = new TextBox();
            btn_categorySearch = new Button();
            btn_roleUpdate = new Button();
            btn_roleFix = new Button();
            btn_roleDelete = new Button();
            btn_roleAdd = new Button();
            lb_roleName = new Label();
            txt_roleName = new TextBox();
            lb_roles_manager_title = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox_listRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listRole).BeginInit();
            SuspendLayout();
            // 
            // groupBox_listRole
            // 
            groupBox_listRole.Controls.Add(dgv_listRole);
            groupBox_listRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_listRole.Location = new Point(23, 232);
            groupBox_listRole.Name = "groupBox_listRole";
            groupBox_listRole.Size = new Size(848, 401);
            groupBox_listRole.TabIndex = 68;
            groupBox_listRole.TabStop = false;
            groupBox_listRole.Text = "Danh sách loại món ăn :";
            // 
            // dgv_listRole
            // 
            dgv_listRole.AllowUserToAddRows = false;
            dgv_listRole.AllowUserToDeleteRows = false;
            dgv_listRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listRole.Dock = DockStyle.Fill;
            dgv_listRole.Location = new Point(3, 26);
            dgv_listRole.Name = "dgv_listRole";
            dgv_listRole.ReadOnly = true;
            dgv_listRole.RowHeadersWidth = 51;
            dgv_listRole.RowTemplate.Height = 29;
            dgv_listRole.Size = new Size(842, 372);
            dgv_listRole.TabIndex = 0;
            // 
            // lb_roles_manager_search
            // 
            lb_roles_manager_search.Location = new Point(917, 43);
            lb_roles_manager_search.Name = "lb_roles_manager_search";
            lb_roles_manager_search.Size = new Size(88, 25);
            lb_roles_manager_search.TabIndex = 67;
            lb_roles_manager_search.Text = "Loại quyền :";
            lb_roles_manager_search.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_roles_manager_search
            // 
            txt_roles_manager_search.Location = new Point(917, 82);
            txt_roles_manager_search.Multiline = true;
            txt_roles_manager_search.Name = "txt_roles_manager_search";
            txt_roles_manager_search.Size = new Size(217, 25);
            txt_roles_manager_search.TabIndex = 66;
            // 
            // btn_categorySearch
            // 
            btn_categorySearch.BackColor = Color.FromArgb(128, 255, 255);
            btn_categorySearch.ForeColor = Color.White;
            btn_categorySearch.Location = new Point(917, 119);
            btn_categorySearch.Name = "btn_categorySearch";
            btn_categorySearch.Size = new Size(217, 40);
            btn_categorySearch.TabIndex = 65;
            btn_categorySearch.Text = "Tìm kiếm";
            btn_categorySearch.UseVisualStyleBackColor = false;
            btn_categorySearch.Click += btn_categorySearch_Click;
            // 
            // btn_roleUpdate
            // 
            btn_roleUpdate.BackColor = Color.Gray;
            btn_roleUpdate.ForeColor = Color.White;
            btn_roleUpdate.Location = new Point(917, 552);
            btn_roleUpdate.Name = "btn_roleUpdate";
            btn_roleUpdate.Size = new Size(217, 78);
            btn_roleUpdate.TabIndex = 64;
            btn_roleUpdate.Text = "Cập nhật";
            btn_roleUpdate.UseVisualStyleBackColor = false;
            btn_roleUpdate.Click += btn_roleUpdate_Click;
            // 
            // btn_roleFix
            // 
            btn_roleFix.ForeColor = Color.Black;
            btn_roleFix.Location = new Point(917, 453);
            btn_roleFix.Name = "btn_roleFix";
            btn_roleFix.Size = new Size(217, 78);
            btn_roleFix.TabIndex = 63;
            btn_roleFix.Text = "Sửa";
            btn_roleFix.UseVisualStyleBackColor = true;
            btn_roleFix.Click += btn_roleFix_Click;
            // 
            // btn_roleDelete
            // 
            btn_roleDelete.BackColor = Color.Tomato;
            btn_roleDelete.ForeColor = Color.White;
            btn_roleDelete.Location = new Point(917, 354);
            btn_roleDelete.Name = "btn_roleDelete";
            btn_roleDelete.Size = new Size(217, 78);
            btn_roleDelete.TabIndex = 62;
            btn_roleDelete.Text = "Xóa";
            btn_roleDelete.UseVisualStyleBackColor = false;
            btn_roleDelete.Click += btn_roleDelete_Click;
            // 
            // btn_roleAdd
            // 
            btn_roleAdd.BackColor = Color.FromArgb(128, 255, 128);
            btn_roleAdd.ForeColor = Color.White;
            btn_roleAdd.Location = new Point(917, 258);
            btn_roleAdd.Name = "btn_roleAdd";
            btn_roleAdd.Size = new Size(217, 78);
            btn_roleAdd.TabIndex = 61;
            btn_roleAdd.Text = "Thêm";
            btn_roleAdd.UseVisualStyleBackColor = false;
            btn_roleAdd.Click += btn_roleAdd_Click;
            // 
            // lb_roleName
            // 
            lb_roleName.Location = new Point(28, 71);
            lb_roleName.Name = "lb_roleName";
            lb_roleName.Size = new Size(116, 25);
            lb_roleName.TabIndex = 60;
            lb_roleName.Text = "Tên quyền :";
            lb_roleName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_roleName
            // 
            txt_roleName.Location = new Point(150, 68);
            txt_roleName.Name = "txt_roleName";
            txt_roleName.Size = new Size(225, 27);
            txt_roleName.TabIndex = 59;
            // 
            // lb_roles_manager_title
            // 
            lb_roles_manager_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_roles_manager_title.Location = new Point(498, 9);
            lb_roles_manager_title.Name = "lb_roles_manager_title";
            lb_roles_manager_title.Size = new Size(260, 42);
            lb_roles_manager_title.TabIndex = 58;
            lb_roles_manager_title.Text = "Quản lý quyền";
            lb_roles_manager_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frm_roles_manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 645);
            Controls.Add(groupBox_listRole);
            Controls.Add(lb_roles_manager_search);
            Controls.Add(txt_roles_manager_search);
            Controls.Add(btn_categorySearch);
            Controls.Add(btn_roleUpdate);
            Controls.Add(btn_roleFix);
            Controls.Add(btn_roleDelete);
            Controls.Add(btn_roleAdd);
            Controls.Add(lb_roleName);
            Controls.Add(txt_roleName);
            Controls.Add(lb_roles_manager_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_roles_manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý quyền";
            groupBox_listRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_listRole).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_listRole;
        private DataGridView dgv_listRole;
        private Label lb_roles_manager_search;
        private TextBox txt_roles_manager_search;
        private Button btn_categorySearch;
        private Button btn_roleUpdate;
        private Button btn_roleFix;
        private Button btn_roleDelete;
        private Button btn_roleAdd;
        private Label lb_roleName;
        private TextBox txt_roleName;
        private Label lb_roles_manager_title;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}