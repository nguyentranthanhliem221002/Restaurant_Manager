namespace PresentationLayer
{
    partial class frm_employees_manager
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lb_employees_manager_search = new Label();
            txt_employees_manager_search = new TextBox();
            btn_employeeSearch = new Button();
            btn_employeeUpdate = new Button();
            btn_employeeFix = new Button();
            btn_employeeDelete = new Button();
            btn_employeeAdd = new Button();
            comboBox_listLevel = new ComboBox();
            lb_employeeLevel = new Label();
            lb_employeePhone = new Label();
            txt_employeePhone = new TextBox();
            lb_employeeName = new Label();
            txt_employeeName = new TextBox();
            lb_employees_manager_title = new Label();
            dgv_listEmployee = new DataGridView();
            groupBox_listEmployee = new GroupBox();
            dateTimePicker_employees_manager_startDate = new DateTimePicker();
            lb_employees_manager_startDate = new Label();
            btn_roles_manager = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_listEmployee).BeginInit();
            groupBox_listEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // lb_employees_manager_search
            // 
            lb_employees_manager_search.Location = new Point(915, 48);
            lb_employees_manager_search.Name = "lb_employees_manager_search";
            lb_employees_manager_search.Size = new Size(88, 25);
            lb_employees_manager_search.TabIndex = 39;
            lb_employees_manager_search.Text = "Nhân viên :";
            lb_employees_manager_search.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_employees_manager_search
            // 
            txt_employees_manager_search.Location = new Point(915, 85);
            txt_employees_manager_search.Multiline = true;
            txt_employees_manager_search.Name = "txt_employees_manager_search";
            txt_employees_manager_search.Size = new Size(217, 25);
            txt_employees_manager_search.TabIndex = 38;
            // 
            // btn_employeeSearch
            // 
            btn_employeeSearch.BackColor = Color.FromArgb(128, 255, 255);
            btn_employeeSearch.ForeColor = Color.White;
            btn_employeeSearch.Location = new Point(915, 122);
            btn_employeeSearch.Name = "btn_employeeSearch";
            btn_employeeSearch.Size = new Size(217, 40);
            btn_employeeSearch.TabIndex = 37;
            btn_employeeSearch.Text = "Tìm kiếm";
            btn_employeeSearch.UseVisualStyleBackColor = false;
            btn_employeeSearch.Click += btn_employeeSearch_Click;
            // 
            // btn_employeeUpdate
            // 
            btn_employeeUpdate.BackColor = Color.Gray;
            btn_employeeUpdate.ForeColor = Color.White;
            btn_employeeUpdate.Location = new Point(915, 555);
            btn_employeeUpdate.Name = "btn_employeeUpdate";
            btn_employeeUpdate.Size = new Size(217, 78);
            btn_employeeUpdate.TabIndex = 34;
            btn_employeeUpdate.Text = "Cập nhật";
            btn_employeeUpdate.UseVisualStyleBackColor = false;
            btn_employeeUpdate.Click += btn_employeeUpdate_Click;
            // 
            // btn_employeeFix
            // 
            btn_employeeFix.ForeColor = Color.Black;
            btn_employeeFix.Location = new Point(915, 456);
            btn_employeeFix.Name = "btn_employeeFix";
            btn_employeeFix.Size = new Size(217, 78);
            btn_employeeFix.TabIndex = 33;
            btn_employeeFix.Text = "Sửa";
            btn_employeeFix.UseVisualStyleBackColor = true;
            btn_employeeFix.Click += btn_employeeFix_Click;
            // 
            // btn_employeeDelete
            // 
            btn_employeeDelete.BackColor = Color.Tomato;
            btn_employeeDelete.ForeColor = Color.White;
            btn_employeeDelete.Location = new Point(915, 357);
            btn_employeeDelete.Name = "btn_employeeDelete";
            btn_employeeDelete.Size = new Size(217, 78);
            btn_employeeDelete.TabIndex = 32;
            btn_employeeDelete.Text = "Xóa";
            btn_employeeDelete.UseVisualStyleBackColor = false;
            btn_employeeDelete.Click += btn_employeeDelete_Click;
            // 
            // btn_employeeAdd
            // 
            btn_employeeAdd.BackColor = Color.FromArgb(128, 255, 128);
            btn_employeeAdd.ForeColor = Color.White;
            btn_employeeAdd.Location = new Point(915, 261);
            btn_employeeAdd.Name = "btn_employeeAdd";
            btn_employeeAdd.Size = new Size(217, 78);
            btn_employeeAdd.TabIndex = 31;
            btn_employeeAdd.Text = "Thêm";
            btn_employeeAdd.UseVisualStyleBackColor = false;
            btn_employeeAdd.Click += btn_employeeAdd_Click;
            // 
            // comboBox_listLevel
            // 
            comboBox_listLevel.FormattingEnabled = true;
            comboBox_listLevel.Location = new Point(143, 203);
            comboBox_listLevel.Name = "comboBox_listLevel";
            comboBox_listLevel.Size = new Size(71, 28);
            comboBox_listLevel.TabIndex = 27;
            comboBox_listLevel.SelectedIndexChanged += comboBox_listLevel_SelectedIndexChanged;
            // 
            // lb_employeeLevel
            // 
            lb_employeeLevel.Location = new Point(21, 201);
            lb_employeeLevel.Name = "lb_employeeLevel";
            lb_employeeLevel.Size = new Size(98, 25);
            lb_employeeLevel.TabIndex = 26;
            lb_employeeLevel.Text = "Chức vụ :";
            lb_employeeLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lb_employeePhone
            // 
            lb_employeePhone.Location = new Point(21, 131);
            lb_employeePhone.Name = "lb_employeePhone";
            lb_employeePhone.Size = new Size(116, 25);
            lb_employeePhone.TabIndex = 25;
            lb_employeePhone.Text = "Số điện thoại :";
            lb_employeePhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_employeePhone
            // 
            txt_employeePhone.Location = new Point(143, 135);
            txt_employeePhone.Name = "txt_employeePhone";
            txt_employeePhone.Size = new Size(225, 27);
            txt_employeePhone.TabIndex = 24;
            // 
            // lb_employeeName
            // 
            lb_employeeName.Location = new Point(21, 68);
            lb_employeeName.Name = "lb_employeeName";
            lb_employeeName.Size = new Size(116, 25);
            lb_employeeName.TabIndex = 23;
            lb_employeeName.Text = "Tên nhân viên :";
            lb_employeeName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_employeeName
            // 
            txt_employeeName.Location = new Point(143, 65);
            txt_employeeName.Name = "txt_employeeName";
            txt_employeeName.Size = new Size(225, 27);
            txt_employeeName.TabIndex = 22;
            // 
            // lb_employees_manager_title
            // 
            lb_employees_manager_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_employees_manager_title.Location = new Point(483, 12);
            lb_employees_manager_title.Name = "lb_employees_manager_title";
            lb_employees_manager_title.Size = new Size(260, 42);
            lb_employees_manager_title.TabIndex = 21;
            lb_employees_manager_title.Text = "Quản lý nhân viên";
            lb_employees_manager_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgv_listEmployee
            // 
            dgv_listEmployee.AllowUserToAddRows = false;
            dgv_listEmployee.AllowUserToDeleteRows = false;
            dgv_listEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listEmployee.Dock = DockStyle.Fill;
            dgv_listEmployee.Location = new Point(3, 26);
            dgv_listEmployee.Name = "dgv_listEmployee";
            dgv_listEmployee.ReadOnly = true;
            dgv_listEmployee.RowHeadersWidth = 51;
            dgv_listEmployee.RowTemplate.Height = 29;
            dgv_listEmployee.Size = new Size(842, 372);
            dgv_listEmployee.TabIndex = 0;
            // 
            // groupBox_listEmployee
            // 
            groupBox_listEmployee.Controls.Add(dgv_listEmployee);
            groupBox_listEmployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_listEmployee.Location = new Point(18, 235);
            groupBox_listEmployee.Name = "groupBox_listEmployee";
            groupBox_listEmployee.Size = new Size(848, 401);
            groupBox_listEmployee.TabIndex = 20;
            groupBox_listEmployee.TabStop = false;
            groupBox_listEmployee.Text = "Danh sách nhân viên :";
            // 
            // dateTimePicker_employees_manager_startDate
            // 
            dateTimePicker_employees_manager_startDate.Location = new Point(523, 63);
            dateTimePicker_employees_manager_startDate.Name = "dateTimePicker_employees_manager_startDate";
            dateTimePicker_employees_manager_startDate.Size = new Size(343, 27);
            dateTimePicker_employees_manager_startDate.TabIndex = 40;
            // 
            // lb_employees_manager_startDate
            // 
            lb_employees_manager_startDate.Location = new Point(401, 65);
            lb_employees_manager_startDate.Name = "lb_employees_manager_startDate";
            lb_employees_manager_startDate.Size = new Size(116, 25);
            lb_employees_manager_startDate.TabIndex = 41;
            lb_employees_manager_startDate.Text = "Ngày vào làm :";
            lb_employees_manager_startDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_roles_manager
            // 
            btn_roles_manager.Location = new Point(220, 203);
            btn_roles_manager.Name = "btn_roles_manager";
            btn_roles_manager.Size = new Size(148, 28);
            btn_roles_manager.TabIndex = 42;
            btn_roles_manager.Text = "Quản lý quyền";
            btn_roles_manager.UseVisualStyleBackColor = true;
            // 
            // frm_employees_manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 645);
            Controls.Add(btn_roles_manager);
            Controls.Add(lb_employees_manager_startDate);
            Controls.Add(dateTimePicker_employees_manager_startDate);
            Controls.Add(lb_employees_manager_search);
            Controls.Add(txt_employees_manager_search);
            Controls.Add(btn_employeeSearch);
            Controls.Add(btn_employeeUpdate);
            Controls.Add(btn_employeeFix);
            Controls.Add(btn_employeeDelete);
            Controls.Add(btn_employeeAdd);
            Controls.Add(comboBox_listLevel);
            Controls.Add(lb_employeeLevel);
            Controls.Add(lb_employeePhone);
            Controls.Add(txt_employeePhone);
            Controls.Add(lb_employeeName);
            Controls.Add(txt_employeeName);
            Controls.Add(lb_employees_manager_title);
            Controls.Add(groupBox_listEmployee);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_employees_manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang quản lý nhân viên";
            Load += frm_employees_manager_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listEmployee).EndInit();
            groupBox_listEmployee.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lb_employees_manager_search;
        private TextBox txt_employees_manager_search;
        private Button btn_employeeSearch;
        private Button btn_employeeUpdate;
        private Button btn_employeeFix;
        private Button btn_employeeDelete;
        private Button btn_employeeAdd;
        private ComboBox comboBox_listLevel;
        private Label lb_employeeLevel;
        private Label lb_employeePhone;
        private TextBox txt_employeePhone;
        private Label lb_employeeName;
        private TextBox txt_employeeName;
        private Label lb_employees_manager_title;
        private DataGridView dgv_listEmployee;
        private GroupBox groupBox_listEmployee;
        private DateTimePicker dateTimePicker_employees_manager_startDate;
        private Label lb_employees_manager_startDate;
        private Button btn_roles_manager;
    }
}