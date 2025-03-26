namespace PresentationLayer.Forms
{
    partial class frm_orderdetails_manager
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_orderdetails_manager));
            dgv_listOrderDetail = new DataGridView();
            btn_saveOrder = new Button();
            groupBox_listOrderDetail = new GroupBox();
            imageList1 = new ImageList(components);
            button2 = new Button();
            tabPage_SecondOrder = new TabPage();
            columnHeader4 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            listView_listDrinkChoose = new ListView();
            button1 = new Button();
            groupBox_drinkInfo = new GroupBox();
            tabPage_Drink = new TabPage();
            tabMenu = new TabControl();
            tabPageFood = new TabPage();
            lb_orderNumber = new Label();
            Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_listOrderDetail).BeginInit();
            groupBox_listOrderDetail.SuspendLayout();
            tabPage_SecondOrder.SuspendLayout();
            groupBox_drinkInfo.SuspendLayout();
            tabPage_Drink.SuspendLayout();
            tabMenu.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_listOrderDetail
            // 
            dgv_listOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listOrderDetail.Columns.AddRange(new DataGridViewColumn[] { Name, Price, Quantity, SubTotal, ID });
            dgv_listOrderDetail.Dock = DockStyle.Fill;
            dgv_listOrderDetail.Location = new Point(3, 23);
            dgv_listOrderDetail.Name = "dgv_listOrderDetail";
            dgv_listOrderDetail.RowHeadersWidth = 51;
            dgv_listOrderDetail.RowTemplate.Height = 29;
            dgv_listOrderDetail.Size = new Size(472, 480);
            dgv_listOrderDetail.TabIndex = 0;
            // 
            // btn_saveOrder
            // 
            btn_saveOrder.BackColor = Color.LawnGreen;
            btn_saveOrder.ForeColor = Color.White;
            btn_saveOrder.Location = new Point(682, 541);
            btn_saveOrder.Name = "btn_saveOrder";
            btn_saveOrder.Size = new Size(475, 53);
            btn_saveOrder.TabIndex = 6;
            btn_saveOrder.Text = "Thiết lập món";
            btn_saveOrder.UseVisualStyleBackColor = false;
            btn_saveOrder.Click += btn_saveOrder_Click;
            // 
            // groupBox_listOrderDetail
            // 
            groupBox_listOrderDetail.BackColor = Color.Transparent;
            groupBox_listOrderDetail.Controls.Add(dgv_listOrderDetail);
            groupBox_listOrderDetail.Location = new Point(682, 29);
            groupBox_listOrderDetail.Name = "groupBox_listOrderDetail";
            groupBox_listOrderDetail.Size = new Size(478, 506);
            groupBox_listOrderDetail.TabIndex = 5;
            groupBox_listOrderDetail.TabStop = false;
            groupBox_listOrderDetail.Text = "Các món ăn đã chọn : ";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "img_food.png");
            imageList1.Images.SetKeyName(1, "img_drink.png");
            imageList1.Images.SetKeyName(2, "icon_secondOrder.png");
            // 
            // button2
            // 
            button2.BackColor = Color.LawnGreen;
            button2.ForeColor = Color.White;
            button2.Location = new Point(678, 512);
            button2.Name = "button2";
            button2.Size = new Size(475, 53);
            button2.TabIndex = 3;
            button2.Text = "Thiết lập món";
            button2.UseVisualStyleBackColor = false;
            // 
            // tabPage_SecondOrder
            // 
            tabPage_SecondOrder.Controls.Add(button2);
            tabPage_SecondOrder.ImageIndex = 2;
            tabPage_SecondOrder.Location = new Point(4, 29);
            tabPage_SecondOrder.Name = "tabPage_SecondOrder";
            tabPage_SecondOrder.Padding = new Padding(3);
            tabPage_SecondOrder.Size = new Size(668, 565);
            tabPage_SecondOrder.TabIndex = 2;
            tabPage_SecondOrder.Text = "Món thêm";
            tabPage_SecondOrder.UseVisualStyleBackColor = true;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tổng tiền";
            columnHeader4.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 1;
            columnHeader3.Text = "Số Lượng";
            columnHeader3.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 2;
            columnHeader2.Text = "Giá";
            columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món ";
            columnHeader1.Width = 150;
            // 
            // listView_listDrinkChoose
            // 
            listView_listDrinkChoose.BackColor = Color.Turquoise;
            listView_listDrinkChoose.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView_listDrinkChoose.Dock = DockStyle.Fill;
            listView_listDrinkChoose.Location = new Point(3, 23);
            listView_listDrinkChoose.Name = "listView_listDrinkChoose";
            listView_listDrinkChoose.Size = new Size(472, 480);
            listView_listDrinkChoose.TabIndex = 0;
            listView_listDrinkChoose.UseCompatibleStateImageBehavior = false;
            listView_listDrinkChoose.View = View.Details;
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(674, 512);
            button1.Name = "button1";
            button1.Size = new Size(478, 53);
            button1.TabIndex = 3;
            button1.Text = "Thiết lập món";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox_drinkInfo
            // 
            groupBox_drinkInfo.BackColor = Color.Transparent;
            groupBox_drinkInfo.Controls.Add(listView_listDrinkChoose);
            groupBox_drinkInfo.Location = new Point(674, 0);
            groupBox_drinkInfo.Name = "groupBox_drinkInfo";
            groupBox_drinkInfo.Size = new Size(478, 506);
            groupBox_drinkInfo.TabIndex = 2;
            groupBox_drinkInfo.TabStop = false;
            groupBox_drinkInfo.Text = "Các món ăn đã chọn : ";
            // 
            // tabPage_Drink
            // 
            tabPage_Drink.BackColor = Color.White;
            tabPage_Drink.Controls.Add(button1);
            tabPage_Drink.Controls.Add(groupBox_drinkInfo);
            tabPage_Drink.ImageIndex = 1;
            tabPage_Drink.Location = new Point(4, 29);
            tabPage_Drink.Name = "tabPage_Drink";
            tabPage_Drink.Padding = new Padding(3);
            tabPage_Drink.Size = new Size(668, 565);
            tabPage_Drink.TabIndex = 1;
            tabPage_Drink.Text = "Thức uống";
            // 
            // tabMenu
            // 
            tabMenu.Controls.Add(tabPageFood);
            tabMenu.Controls.Add(tabPage_Drink);
            tabMenu.Controls.Add(tabPage_SecondOrder);
            tabMenu.ImageList = imageList1;
            tabMenu.Location = new Point(0, 0);
            tabMenu.Name = "tabMenu";
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(676, 598);
            tabMenu.TabIndex = 4;
            // 
            // tabPageFood
            // 
            tabPageFood.BackColor = Color.White;
            tabPageFood.ForeColor = SystemColors.ControlText;
            tabPageFood.ImageIndex = 0;
            tabPageFood.Location = new Point(4, 29);
            tabPageFood.Name = "tabPageFood";
            tabPageFood.Padding = new Padding(3);
            tabPageFood.Size = new Size(668, 565);
            tabPageFood.TabIndex = 0;
            tabPageFood.Text = "Đồ ăn";
            // 
            // lb_orderNumber
            // 
            lb_orderNumber.AutoSize = true;
            lb_orderNumber.Location = new Point(682, 6);
            lb_orderNumber.Name = "lb_orderNumber";
            lb_orderNumber.Size = new Size(30, 20);
            lb_orderNumber.TabIndex = 7;
            lb_orderNumber.Text = "???";
            lb_orderNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Name
            // 
            Name.HeaderText = "Tên món";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Price
            // 
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Thành tiền";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // frm_orderdetails_manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 645);
            Controls.Add(lb_orderNumber);
            Controls.Add(btn_saveOrder);
            Controls.Add(groupBox_listOrderDetail);
            Controls.Add(tabMenu);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý chi tiết đơn hàng";
            Load += frm_orderdetails_manager_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listOrderDetail).EndInit();
            groupBox_listOrderDetail.ResumeLayout(false);
            tabPage_SecondOrder.ResumeLayout(false);
            groupBox_drinkInfo.ResumeLayout(false);
            tabPage_Drink.ResumeLayout(false);
            tabMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_listOrderDetail;
        private Button btn_saveOrder;
        private GroupBox groupBox_listOrderDetail;
        private ImageList imageList1;
        private Button button2;
        private TabPage tabPage_SecondOrder;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ListView listView_listDrinkChoose;
        private Button button1;
        private GroupBox groupBox_drinkInfo;
        private TabPage tabPage_Drink;
        private TabControl tabMenu;
        private TabPage tabPageFood;
        private Label lb_orderNumber;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn ID;
    }
}