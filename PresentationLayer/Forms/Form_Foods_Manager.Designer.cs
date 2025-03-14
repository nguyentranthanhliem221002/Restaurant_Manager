namespace PresentationLayer
{
    partial class frm_foods_manager
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
            groupBox_listFood = new GroupBox();
            dgv_listFood = new DataGridView();
            lb_foods_manager_title = new Label();
            txt_foodName = new TextBox();
            lb_foodName = new Label();
            lb_foodPrice = new Label();
            txt_foodPrice = new TextBox();
            lb_foodCategory = new Label();
            comboBox_listCategory = new ComboBox();
            lb_foodImage = new Label();
            pictureBox_upload = new PictureBox();
            btn_foodImage = new Button();
            btn_foodAdd = new Button();
            btn_foodDelete = new Button();
            btn_foodFix = new Button();
            btn_foodUpdate = new Button();
            lb_foods_manager_description = new Label();
            txt_foods_manager_description = new TextBox();
            btn_foodSearch = new Button();
            txt_foods_manager_search = new TextBox();
            lb_foods_manager_search = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btn_categories_manager = new Button();
            groupBox_listFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_upload).BeginInit();
            SuspendLayout();
            // 
            // groupBox_listFood
            // 
            groupBox_listFood.Controls.Add(dgv_listFood);
            groupBox_listFood.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_listFood.Location = new Point(12, 232);
            groupBox_listFood.Name = "groupBox_listFood";
            groupBox_listFood.Size = new Size(848, 401);
            groupBox_listFood.TabIndex = 0;
            groupBox_listFood.TabStop = false;
            groupBox_listFood.Text = "Danh sách món ăn :";
            // 
            // dgv_listFood
            // 
            dgv_listFood.AllowUserToAddRows = false;
            dgv_listFood.AllowUserToDeleteRows = false;
            dgv_listFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listFood.Dock = DockStyle.Fill;
            dgv_listFood.Location = new Point(3, 26);
            dgv_listFood.Name = "dgv_listFood";
            dgv_listFood.ReadOnly = true;
            dgv_listFood.RowHeadersWidth = 51;
            dgv_listFood.RowTemplate.Height = 29;
            dgv_listFood.Size = new Size(842, 372);
            dgv_listFood.TabIndex = 0;
            // 
            // lb_foods_manager_title
            // 
            lb_foods_manager_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_foods_manager_title.Location = new Point(477, 9);
            lb_foods_manager_title.Name = "lb_foods_manager_title";
            lb_foods_manager_title.Size = new Size(260, 42);
            lb_foods_manager_title.TabIndex = 1;
            lb_foods_manager_title.Text = "Quản lý món ăn";
            lb_foods_manager_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_foodName
            // 
            txt_foodName.Location = new Point(99, 63);
            txt_foodName.Name = "txt_foodName";
            txt_foodName.Size = new Size(176, 27);
            txt_foodName.TabIndex = 2;
            // 
            // lb_foodName
            // 
            lb_foodName.Location = new Point(15, 65);
            lb_foodName.Name = "lb_foodName";
            lb_foodName.Size = new Size(78, 25);
            lb_foodName.TabIndex = 3;
            lb_foodName.Text = "Tên món :";
            lb_foodName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lb_foodPrice
            // 
            lb_foodPrice.Location = new Point(15, 128);
            lb_foodPrice.Name = "lb_foodPrice";
            lb_foodPrice.Size = new Size(78, 25);
            lb_foodPrice.TabIndex = 5;
            lb_foodPrice.Text = "Giá :";
            lb_foodPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_foodPrice
            // 
            txt_foodPrice.Location = new Point(99, 126);
            txt_foodPrice.Name = "txt_foodPrice";
            txt_foodPrice.Size = new Size(176, 27);
            txt_foodPrice.TabIndex = 4;
            // 
            // lb_foodCategory
            // 
            lb_foodCategory.Location = new Point(15, 198);
            lb_foodCategory.Name = "lb_foodCategory";
            lb_foodCategory.Size = new Size(98, 25);
            lb_foodCategory.TabIndex = 6;
            lb_foodCategory.Text = "Loại :";
            lb_foodCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox_listCategory
            // 
            comboBox_listCategory.FormattingEnabled = true;
            comboBox_listCategory.Location = new Point(99, 198);
            comboBox_listCategory.Name = "comboBox_listCategory";
            comboBox_listCategory.Size = new Size(71, 28);
            comboBox_listCategory.TabIndex = 7;
            // 
            // lb_foodImage
            // 
            lb_foodImage.Location = new Point(642, 65);
            lb_foodImage.Name = "lb_foodImage";
            lb_foodImage.Size = new Size(98, 25);
            lb_foodImage.TabIndex = 8;
            lb_foodImage.Text = "Hình ảnh :";
            lb_foodImage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox_upload
            // 
            pictureBox_upload.Location = new Point(642, 91);
            pictureBox_upload.Name = "pictureBox_upload";
            pictureBox_upload.Size = new Size(217, 137);
            pictureBox_upload.TabIndex = 9;
            pictureBox_upload.TabStop = false;
            // 
            // btn_foodImage
            // 
            btn_foodImage.Location = new Point(726, 63);
            btn_foodImage.Name = "btn_foodImage";
            btn_foodImage.Size = new Size(133, 27);
            btn_foodImage.TabIndex = 10;
            btn_foodImage.Text = "Tải lên";
            btn_foodImage.UseVisualStyleBackColor = true;
            btn_foodImage.Click += btn_foodImage_Click;
            // 
            // btn_foodAdd
            // 
            btn_foodAdd.BackColor = Color.FromArgb(128, 255, 128);
            btn_foodAdd.ForeColor = Color.White;
            btn_foodAdd.Location = new Point(909, 258);
            btn_foodAdd.Name = "btn_foodAdd";
            btn_foodAdd.Size = new Size(217, 78);
            btn_foodAdd.TabIndex = 11;
            btn_foodAdd.Text = "Thêm";
            btn_foodAdd.UseVisualStyleBackColor = false;
            btn_foodAdd.Click += btn_foodAdd_Click;
            // 
            // btn_foodDelete
            // 
            btn_foodDelete.BackColor = Color.Tomato;
            btn_foodDelete.ForeColor = Color.White;
            btn_foodDelete.Location = new Point(909, 354);
            btn_foodDelete.Name = "btn_foodDelete";
            btn_foodDelete.Size = new Size(217, 78);
            btn_foodDelete.TabIndex = 12;
            btn_foodDelete.Text = "Xóa";
            btn_foodDelete.UseVisualStyleBackColor = false;
            btn_foodDelete.Click += btn_foodDelete_Click;
            // 
            // btn_foodFix
            // 
            btn_foodFix.ForeColor = Color.Black;
            btn_foodFix.Location = new Point(909, 453);
            btn_foodFix.Name = "btn_foodFix";
            btn_foodFix.Size = new Size(217, 78);
            btn_foodFix.TabIndex = 13;
            btn_foodFix.Text = "Sửa";
            btn_foodFix.UseVisualStyleBackColor = true;
            btn_foodFix.Click += btn_foodFix_Click;
            // 
            // btn_foodUpdate
            // 
            btn_foodUpdate.BackColor = Color.Gray;
            btn_foodUpdate.ForeColor = Color.White;
            btn_foodUpdate.Location = new Point(909, 552);
            btn_foodUpdate.Name = "btn_foodUpdate";
            btn_foodUpdate.Size = new Size(217, 78);
            btn_foodUpdate.TabIndex = 14;
            btn_foodUpdate.Text = "Cập nhật";
            btn_foodUpdate.UseVisualStyleBackColor = false;
            btn_foodUpdate.Click += btn_foodUpdate_Click;
            // 
            // lb_foods_manager_description
            // 
            lb_foods_manager_description.Location = new Point(322, 63);
            lb_foods_manager_description.Name = "lb_foods_manager_description";
            lb_foods_manager_description.Size = new Size(98, 25);
            lb_foods_manager_description.TabIndex = 16;
            lb_foods_manager_description.Text = "Chú thích :";
            lb_foods_manager_description.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_foods_manager_description
            // 
            txt_foods_manager_description.Location = new Point(322, 91);
            txt_foods_manager_description.Multiline = true;
            txt_foods_manager_description.Name = "txt_foods_manager_description";
            txt_foods_manager_description.Size = new Size(268, 141);
            txt_foods_manager_description.TabIndex = 15;
            // 
            // btn_foodSearch
            // 
            btn_foodSearch.BackColor = Color.FromArgb(128, 255, 255);
            btn_foodSearch.ForeColor = Color.White;
            btn_foodSearch.Location = new Point(909, 119);
            btn_foodSearch.Name = "btn_foodSearch";
            btn_foodSearch.Size = new Size(217, 40);
            btn_foodSearch.TabIndex = 17;
            btn_foodSearch.Text = "Tìm kiếm";
            btn_foodSearch.UseVisualStyleBackColor = false;
            btn_foodSearch.Click += btn_foodSearch_Click;
            // 
            // txt_foods_manager_search
            // 
            txt_foods_manager_search.Location = new Point(909, 82);
            txt_foods_manager_search.Multiline = true;
            txt_foods_manager_search.Name = "txt_foods_manager_search";
            txt_foods_manager_search.Size = new Size(217, 25);
            txt_foods_manager_search.TabIndex = 18;
            // 
            // lb_foods_manager_search
            // 
            lb_foods_manager_search.Location = new Point(909, 45);
            lb_foods_manager_search.Name = "lb_foods_manager_search";
            lb_foods_manager_search.Size = new Size(80, 25);
            lb_foods_manager_search.TabIndex = 19;
            lb_foods_manager_search.Text = "Món ăn :";
            lb_foods_manager_search.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btn_categories_manager
            // 
            btn_categories_manager.Location = new Point(176, 198);
            btn_categories_manager.Name = "btn_categories_manager";
            btn_categories_manager.Size = new Size(99, 28);
            btn_categories_manager.TabIndex = 20;
            btn_categories_manager.Text = "Quản lý loại ";
            btn_categories_manager.UseVisualStyleBackColor = true;
            btn_categories_manager.Click += btn_categories_manager_Click;
            // 
            // frm_foods_manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 645);
            Controls.Add(btn_categories_manager);
            Controls.Add(lb_foods_manager_search);
            Controls.Add(txt_foods_manager_search);
            Controls.Add(btn_foodSearch);
            Controls.Add(lb_foods_manager_description);
            Controls.Add(txt_foods_manager_description);
            Controls.Add(btn_foodUpdate);
            Controls.Add(btn_foodFix);
            Controls.Add(btn_foodDelete);
            Controls.Add(btn_foodAdd);
            Controls.Add(btn_foodImage);
            Controls.Add(pictureBox_upload);
            Controls.Add(lb_foodImage);
            Controls.Add(comboBox_listCategory);
            Controls.Add(lb_foodCategory);
            Controls.Add(lb_foodPrice);
            Controls.Add(txt_foodPrice);
            Controls.Add(lb_foodName);
            Controls.Add(txt_foodName);
            Controls.Add(lb_foods_manager_title);
            Controls.Add(groupBox_listFood);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_foods_manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang quản lý món ăn";
            Load += frm_foods_manager_Load;
            groupBox_listFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_listFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_upload).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_listFood;
        private DataGridView dgv__listFood;
        private Label lb_foods_manager_title;
        private TextBox txt_foodName;
        private Label lb_foodName;
        private Label lb_foodPrice;
        private TextBox txt_foodPrice;
        private Label lb_foodCategory;
        private ComboBox comboBox_listCategory;
        private Label lb_foodImage;
        private PictureBox pictureBox_upload;
        private Button btn_foodImage;
        private Button btn_foodAdd;
        private Button btn_foodDelete;
        private Button btn_foodFix;
        private Button btn_foodUpdate;
        private DataGridView dgv_listFood;
        private Label lb_foods_manager_description;
        private TextBox txt_foods_manager_description;
        private Button btn_foodSearch;
        private TextBox txt_foods_manager_search;
        private Label lb_foods_manager_search;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btn_categories_manager;
    }
}