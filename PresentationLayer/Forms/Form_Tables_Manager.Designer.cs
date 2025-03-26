namespace PresentationLayer.Forms
{
    partial class frm_tables_manager
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
            groupBox_list_table = new GroupBox();
            flowLayoutPanel_list_table = new FlowLayoutPanel();
            groupBox_tableInfo = new GroupBox();
            lb_tableStatus = new Label();
            lb_tableNumber = new Label();
            listView_listTableChoose = new ListView();
            Name = new ColumnHeader();
            Price = new ColumnHeader();
            Quantiy = new ColumnHeader();
            SubTotal = new ColumnHeader();
            btn_pay = new Button();
            btn_print_bill = new Button();
            groupBox_list_option_Pay = new GroupBox();
            radioButton_option_momo = new RadioButton();
            radioButton_option_bank = new RadioButton();
            radioButton_option_cash = new RadioButton();
            s = new Label();
            lb_subTotal = new Label();
            groupBox_list_table.SuspendLayout();
            groupBox_tableInfo.SuspendLayout();
            groupBox_list_option_Pay.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_list_table
            // 
            groupBox_list_table.Controls.Add(flowLayoutPanel_list_table);
            groupBox_list_table.Location = new Point(12, 57);
            groupBox_list_table.Name = "groupBox_list_table";
            groupBox_list_table.Size = new Size(654, 576);
            groupBox_list_table.TabIndex = 1;
            groupBox_list_table.TabStop = false;
            groupBox_list_table.Text = "Sơ đồ bàn ăn :";
            // 
            // flowLayoutPanel_list_table
            // 
            flowLayoutPanel_list_table.AutoScroll = true;
            flowLayoutPanel_list_table.BackColor = Color.Turquoise;
            flowLayoutPanel_list_table.Dock = DockStyle.Fill;
            flowLayoutPanel_list_table.Location = new Point(3, 23);
            flowLayoutPanel_list_table.Name = "flowLayoutPanel_list_table";
            flowLayoutPanel_list_table.Size = new Size(648, 550);
            flowLayoutPanel_list_table.TabIndex = 1;
            // 
            // groupBox_tableInfo
            // 
            groupBox_tableInfo.Controls.Add(lb_tableStatus);
            groupBox_tableInfo.Controls.Add(lb_tableNumber);
            groupBox_tableInfo.Controls.Add(listView_listTableChoose);
            groupBox_tableInfo.Location = new Point(710, 57);
            groupBox_tableInfo.Name = "groupBox_tableInfo";
            groupBox_tableInfo.Size = new Size(429, 375);
            groupBox_tableInfo.TabIndex = 2;
            groupBox_tableInfo.TabStop = false;
            groupBox_tableInfo.Text = "Thông tin bàn ăn :";
            // 
            // lb_tableStatus
            // 
            lb_tableStatus.AutoSize = true;
            lb_tableStatus.Location = new Point(6, 64);
            lb_tableStatus.Name = "lb_tableStatus";
            lb_tableStatus.Size = new Size(30, 20);
            lb_tableStatus.TabIndex = 8;
            lb_tableStatus.Text = "???";
            // 
            // lb_tableNumber
            // 
            lb_tableNumber.AutoSize = true;
            lb_tableNumber.Location = new Point(6, 32);
            lb_tableNumber.Name = "lb_tableNumber";
            lb_tableNumber.Size = new Size(30, 20);
            lb_tableNumber.TabIndex = 7;
            lb_tableNumber.Text = "???";
            // 
            // listView_listTableChoose
            // 
            listView_listTableChoose.Columns.AddRange(new ColumnHeader[] { Name, Price, Quantiy, SubTotal });
            listView_listTableChoose.Location = new Point(3, 87);
            listView_listTableChoose.Name = "listView_listTableChoose";
            listView_listTableChoose.Size = new Size(423, 285);
            listView_listTableChoose.TabIndex = 4;
            listView_listTableChoose.UseCompatibleStateImageBehavior = false;
            listView_listTableChoose.View = View.Details;
            // 
            // Name
            // 
            Name.Text = "Tên món";
            Name.Width = 120;
            // 
            // Price
            // 
            Price.Text = "Giá";
            Price.Width = 120;
            // 
            // Quantiy
            // 
            Quantiy.Text = "Số lượng";
            // 
            // SubTotal
            // 
            SubTotal.Text = "Tổng tiền";
            SubTotal.Width = 120;
            // 
            // btn_pay
            // 
            btn_pay.BackColor = Color.FromArgb(192, 255, 192);
            btn_pay.Location = new Point(710, 586);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(312, 47);
            btn_pay.TabIndex = 3;
            btn_pay.Text = "Thanh toán";
            btn_pay.UseVisualStyleBackColor = false;
            btn_pay.Click += btn_pay_Click;
            // 
            // btn_print_bill
            // 
            btn_print_bill.Location = new Point(1044, 586);
            btn_print_bill.Name = "btn_print_bill";
            btn_print_bill.Size = new Size(95, 47);
            btn_print_bill.TabIndex = 4;
            btn_print_bill.Text = "In hóa đơn";
            btn_print_bill.UseVisualStyleBackColor = true;
            btn_print_bill.Click += btn_print_bill_Click;
            // 
            // groupBox_list_option_Pay
            // 
            groupBox_list_option_Pay.Controls.Add(radioButton_option_momo);
            groupBox_list_option_Pay.Controls.Add(radioButton_option_bank);
            groupBox_list_option_Pay.Controls.Add(radioButton_option_cash);
            groupBox_list_option_Pay.Location = new Point(710, 479);
            groupBox_list_option_Pay.Name = "groupBox_list_option_Pay";
            groupBox_list_option_Pay.Size = new Size(429, 89);
            groupBox_list_option_Pay.TabIndex = 3;
            groupBox_list_option_Pay.TabStop = false;
            groupBox_list_option_Pay.Text = "Phương thức thanh toán :";
            // 
            // radioButton_option_momo
            // 
            radioButton_option_momo.AutoSize = true;
            radioButton_option_momo.Location = new Point(323, 41);
            radioButton_option_momo.Name = "radioButton_option_momo";
            radioButton_option_momo.Size = new Size(74, 24);
            radioButton_option_momo.TabIndex = 2;
            radioButton_option_momo.TabStop = true;
            radioButton_option_momo.Text = "Momo";
            radioButton_option_momo.UseVisualStyleBackColor = true;
            // 
            // radioButton_option_bank
            // 
            radioButton_option_bank.AutoSize = true;
            radioButton_option_bank.Location = new Point(169, 41);
            radioButton_option_bank.Name = "radioButton_option_bank";
            radioButton_option_bank.Size = new Size(103, 24);
            radioButton_option_bank.TabIndex = 1;
            radioButton_option_bank.TabStop = true;
            radioButton_option_bank.Text = "Ngân hàng";
            radioButton_option_bank.UseVisualStyleBackColor = true;
            // 
            // radioButton_option_cash
            // 
            radioButton_option_cash.AutoSize = true;
            radioButton_option_cash.Location = new Point(35, 41);
            radioButton_option_cash.Name = "radioButton_option_cash";
            radioButton_option_cash.Size = new Size(88, 24);
            radioButton_option_cash.TabIndex = 0;
            radioButton_option_cash.TabStop = true;
            radioButton_option_cash.Text = "Tiền mặt";
            radioButton_option_cash.UseVisualStyleBackColor = true;
            // 
            // s
            // 
            s.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            s.Location = new Point(474, 9);
            s.Name = "s";
            s.Size = new Size(260, 42);
            s.TabIndex = 2;
            s.Text = "Sơ đồ bàn ăn";
            s.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_subTotal
            // 
            lb_subTotal.AutoSize = true;
            lb_subTotal.Location = new Point(710, 446);
            lb_subTotal.Name = "lb_subTotal";
            lb_subTotal.Size = new Size(30, 20);
            lb_subTotal.TabIndex = 7;
            lb_subTotal.Text = "???";
            lb_subTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frm_tables_manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 645);
            Controls.Add(lb_subTotal);
            Controls.Add(s);
            Controls.Add(btn_pay);
            Controls.Add(btn_print_bill);
            Controls.Add(groupBox_list_option_Pay);
            Controls.Add(groupBox_tableInfo);
            Controls.Add(groupBox_list_table);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang quản lý bàn ăn";
            Load += frm_tables_manager_Load;
            groupBox_list_table.ResumeLayout(false);
            groupBox_tableInfo.ResumeLayout(false);
            groupBox_tableInfo.PerformLayout();
            groupBox_list_option_Pay.ResumeLayout(false);
            groupBox_list_option_Pay.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox_list_table;
        private GroupBox groupBox_tableInfo;
        private Button btn_pay;
        private Button btn_print_bill;
        private GroupBox groupBox_list_option_Pay;
        private RadioButton radioButton_option_cash;
        private RadioButton radioButton_option_momo;
        private RadioButton radioButton_option_bank;
        private Label s;
        private ListView listView_listTableChoose;
        private FlowLayoutPanel flowLayoutPanel_list_table;
        private Label lb_subTotal;
        private Label lb_numberTable;
        private Label label_status;
        private Label lb_statuss;
        private Label lb_tableNumber;
        private Label lb_tableStatus;
        private ColumnHeader Name;
        private ColumnHeader Price;
        private ColumnHeader Quantiy;
        private ColumnHeader SubTotal;
    }
}