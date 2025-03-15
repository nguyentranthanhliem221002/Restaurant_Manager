namespace PresentationLayer
{
    partial class frm_foods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_foods));
            tabMenu = new TabControl();
            tabPageFood = new TabPage();
            tabPage_Drink = new TabPage();
            button1 = new Button();
            groupBox_drinkInfo = new GroupBox();
            listView_listDrinkChoose = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            tabPage_SecondOrder = new TabPage();
            button2 = new Button();
            imageList1 = new ImageList(components);
            btn_saveOrder = new Button();
            groupBox_listfoodInfo = new GroupBox();
            dgv_listFoodInfo = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            tabMenu.SuspendLayout();
            tabPage_Drink.SuspendLayout();
            groupBox_drinkInfo.SuspendLayout();
            tabPage_SecondOrder.SuspendLayout();
            groupBox_listfoodInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listFoodInfo).BeginInit();
            SuspendLayout();
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
            tabMenu.TabIndex = 0;
            // 
            // tabPageFood
            // 
            tabPageFood.BackColor = Color.White;
            tabPageFood.ForeColor = SystemColors.ControlText;
            tabPageFood.ImageIndex = 0;
            tabPageFood.Location = new Point(4, 29);
            tabPageFood.Name = "tabPageFood";
            tabPageFood.Padding = new Padding(3);
            tabPageFood.Size = new Size(617, 565);
            tabPageFood.TabIndex = 0;
            tabPageFood.Text = "Đồ ăn";
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
            tabPage_Drink.Size = new Size(617, 565);
            tabPage_Drink.TabIndex = 1;
            tabPage_Drink.Text = "Thức uống";
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
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món ";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 2;
            columnHeader2.Text = "Giá";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 1;
            columnHeader3.Text = "Số Lượng";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tổng tiền";
            columnHeader4.Width = 100;
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
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "img_food.png");
            imageList1.Images.SetKeyName(1, "img_drink.png");
            imageList1.Images.SetKeyName(2, "icon_secondOrder.png");
            // 
            // btn_saveOrder
            // 
            btn_saveOrder.BackColor = Color.LawnGreen;
            btn_saveOrder.ForeColor = Color.White;
            btn_saveOrder.Location = new Point(682, 541);
            btn_saveOrder.Name = "btn_saveOrder";
            btn_saveOrder.Size = new Size(475, 53);
            btn_saveOrder.TabIndex = 3;
            btn_saveOrder.Text = "Thiết lập món";
            btn_saveOrder.UseVisualStyleBackColor = false;
            btn_saveOrder.Click += btn_saveOrder_Click;
            // 
            // groupBox_listfoodInfo
            // 
            groupBox_listfoodInfo.BackColor = Color.Transparent;
            groupBox_listfoodInfo.Controls.Add(dgv_listFoodInfo);
            groupBox_listfoodInfo.Location = new Point(682, 29);
            groupBox_listfoodInfo.Name = "groupBox_listfoodInfo";
            groupBox_listfoodInfo.Size = new Size(478, 506);
            groupBox_listfoodInfo.TabIndex = 2;
            groupBox_listfoodInfo.TabStop = false;
            groupBox_listfoodInfo.Text = "Các món ăn đã chọn : ";
            // 
            // dgv_listFoodInfo
            // 
            dgv_listFoodInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listFoodInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listFoodInfo.Columns.AddRange(new DataGridViewColumn[] { Name, Price, Quantity, Total });
            dgv_listFoodInfo.Dock = DockStyle.Fill;
            dgv_listFoodInfo.Location = new Point(3, 23);
            dgv_listFoodInfo.Name = "dgv_listFoodInfo";
            dgv_listFoodInfo.RowHeadersWidth = 51;
            dgv_listFoodInfo.RowTemplate.Height = 29;
            dgv_listFoodInfo.Size = new Size(472, 480);
            dgv_listFoodInfo.TabIndex = 0;
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
            // Total
            // 
            Total.HeaderText = "Thành tiền";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            // 
            // frm_foods
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 645);
            Controls.Add(btn_saveOrder);
            Controls.Add(groupBox_listfoodInfo);
            Controls.Add(tabMenu);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cs";
            tabMenu.ResumeLayout(false);
            tabPage_Drink.ResumeLayout(false);
            groupBox_drinkInfo.ResumeLayout(false);
            tabPage_SecondOrder.ResumeLayout(false);
            groupBox_listfoodInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_listFoodInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMenu;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ImageList imageList1;
        private TabPage tabPageFood;
        private TabPage tabPage_Drink;
        private TabPage tabPage_SecondOrder;
        private Button button1;
        private GroupBox groupBox_drinkInfo;
        private ListView listView_listDrinkChoose;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button2;
        private Button btn_saveOrder;
        private GroupBox groupBox_listfoodInfo;
        private DataGridView dgv_listFoodInfo;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
    }
}