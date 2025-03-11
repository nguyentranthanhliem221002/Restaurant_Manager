namespace PresentationLayer.Forms
{
    partial class frm_categories_manager
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
            txt_employees_manager_search = new TextBox();
            btn_categorySearch = new Button();
            btn_categoryUpdate = new Button();
            btn_categoryFix = new Button();
            btn_categoryDelete = new Button();
            btn_categoryAdd = new Button();
            lb_categoryName = new Label();
            txt_employeeName = new TextBox();
            lb_categories_manager_title = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lb_employees_manager_search = new Label();
            SuspendLayout();
            // 
            // txt_employees_manager_search
            // 
            txt_employees_manager_search.Location = new Point(919, 82);
            txt_employees_manager_search.Multiline = true;
            txt_employees_manager_search.Name = "txt_employees_manager_search";
            txt_employees_manager_search.Size = new Size(217, 25);
            txt_employees_manager_search.TabIndex = 55;
            // 
            // btn_categorySearch
            // 
            btn_categorySearch.BackColor = Color.FromArgb(128, 255, 255);
            btn_categorySearch.ForeColor = Color.White;
            btn_categorySearch.Location = new Point(919, 119);
            btn_categorySearch.Name = "btn_categorySearch";
            btn_categorySearch.Size = new Size(217, 40);
            btn_categorySearch.TabIndex = 54;
            btn_categorySearch.Text = "Tìm kiếm";
            btn_categorySearch.UseVisualStyleBackColor = false;
            // 
            // btn_categoryUpdate
            // 
            btn_categoryUpdate.BackColor = Color.Gray;
            btn_categoryUpdate.ForeColor = Color.White;
            btn_categoryUpdate.Location = new Point(919, 552);
            btn_categoryUpdate.Name = "btn_categoryUpdate";
            btn_categoryUpdate.Size = new Size(217, 78);
            btn_categoryUpdate.TabIndex = 53;
            btn_categoryUpdate.Text = "Cập nhật";
            btn_categoryUpdate.UseVisualStyleBackColor = false;
            // 
            // btn_categoryFix
            // 
            btn_categoryFix.ForeColor = Color.Black;
            btn_categoryFix.Location = new Point(919, 453);
            btn_categoryFix.Name = "btn_categoryFix";
            btn_categoryFix.Size = new Size(217, 78);
            btn_categoryFix.TabIndex = 52;
            btn_categoryFix.Text = "Sửa";
            btn_categoryFix.UseVisualStyleBackColor = true;
            // 
            // btn_categoryDelete
            // 
            btn_categoryDelete.BackColor = Color.Tomato;
            btn_categoryDelete.ForeColor = Color.White;
            btn_categoryDelete.Location = new Point(919, 354);
            btn_categoryDelete.Name = "btn_categoryDelete";
            btn_categoryDelete.Size = new Size(217, 78);
            btn_categoryDelete.TabIndex = 51;
            btn_categoryDelete.Text = "Xóa";
            btn_categoryDelete.UseVisualStyleBackColor = false;
            // 
            // btn_categoryAdd
            // 
            btn_categoryAdd.BackColor = Color.FromArgb(128, 255, 128);
            btn_categoryAdd.ForeColor = Color.White;
            btn_categoryAdd.Location = new Point(919, 258);
            btn_categoryAdd.Name = "btn_categoryAdd";
            btn_categoryAdd.Size = new Size(217, 78);
            btn_categoryAdd.TabIndex = 50;
            btn_categoryAdd.Text = "Thêm";
            btn_categoryAdd.UseVisualStyleBackColor = false;
            // 
            // lb_categoryName
            // 
            lb_categoryName.Location = new Point(25, 65);
            lb_categoryName.Name = "lb_categoryName";
            lb_categoryName.Size = new Size(116, 25);
            lb_categoryName.TabIndex = 45;
            lb_categoryName.Text = "Tên loại món ăn :";
            lb_categoryName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_employeeName
            // 
            txt_employeeName.Location = new Point(147, 62);
            txt_employeeName.Name = "txt_employeeName";
            txt_employeeName.Size = new Size(225, 27);
            txt_employeeName.TabIndex = 44;
            // 
            // lb_categories_manager_title
            // 
            lb_categories_manager_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_categories_manager_title.Location = new Point(487, 9);
            lb_categories_manager_title.Name = "lb_categories_manager_title";
            lb_categories_manager_title.Size = new Size(260, 42);
            lb_categories_manager_title.TabIndex = 43;
            lb_categories_manager_title.Text = "Quản lý loại món ăn";
            lb_categories_manager_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // lb_employees_manager_search
            // 
            lb_employees_manager_search.Location = new Point(919, 43);
            lb_employees_manager_search.Name = "lb_employees_manager_search";
            lb_employees_manager_search.Size = new Size(88, 25);
            lb_employees_manager_search.TabIndex = 56;
            lb_employees_manager_search.Text = "Loại món ăn :";
            lb_employees_manager_search.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frm_categories_manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 645);
            Controls.Add(lb_employees_manager_search);
            Controls.Add(txt_employees_manager_search);
            Controls.Add(btn_categorySearch);
            Controls.Add(btn_categoryUpdate);
            Controls.Add(btn_categoryFix);
            Controls.Add(btn_categoryDelete);
            Controls.Add(btn_categoryAdd);
            Controls.Add(lb_categoryName);
            Controls.Add(txt_employeeName);
            Controls.Add(lb_categories_manager_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_categories_manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý loại món ăn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_employees_manager_search;
        private Button btn_categorySearch;
        private Button btn_categoryUpdate;
        private Button btn_categoryFix;
        private Button btn_categoryDelete;
        private Button btn_categoryAdd;
        private Label lb_categoryName;
        private TextBox txt_employeeName;
        private Label lb_categories_manager_title;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lb_employees_manager_search;
    }
}