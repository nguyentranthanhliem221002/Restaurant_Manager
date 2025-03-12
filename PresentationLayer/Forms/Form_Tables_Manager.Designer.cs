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
            this.Load += new System.EventHandler(this.frm_tables_manager_Load);

            groupBox_list_table = new GroupBox();
            flowLayoutPanel_list_table = new FlowLayoutPanel();
            groupBox_tableInfo = new GroupBox();
            listView1 = new ListView();
            btn_pay = new Button();
            btn_print_bill = new Button();
            groupBox_list_option_Pay = new GroupBox();
            radioButton_option_momo = new RadioButton();
            radioButton_option_bank = new RadioButton();
            radioButton_option_cash = new RadioButton();
            s = new Label();
            lb_total = new Label();
            label2 = new Label();
            label1 = new Label();
            lb_table_number = new Label();
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
            flowLayoutPanel_list_table.BackColor = Color.Silver;
            flowLayoutPanel_list_table.Dock = DockStyle.Fill;
            flowLayoutPanel_list_table.Location = new Point(3, 23);
            flowLayoutPanel_list_table.Name = "flowLayoutPanel_list_table";
            flowLayoutPanel_list_table.Size = new Size(648, 550);
            flowLayoutPanel_list_table.TabIndex = 1;
            // 
            // groupBox_tableInfo
            // 
            groupBox_tableInfo.Controls.Add(listView1);
            groupBox_tableInfo.Location = new Point(710, 57);
            groupBox_tableInfo.Name = "groupBox_tableInfo";
            groupBox_tableInfo.Size = new Size(429, 375);
            groupBox_tableInfo.TabIndex = 2;
            groupBox_tableInfo.TabStop = false;
            groupBox_tableInfo.Text = "Thông tin bàn ăn :";
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(3, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(423, 349);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
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
            // 
            // btn_print_bill
            // 
            btn_print_bill.Location = new Point(1044, 586);
            btn_print_bill.Name = "btn_print_bill";
            btn_print_bill.Size = new Size(95, 47);
            btn_print_bill.TabIndex = 4;
            btn_print_bill.Text = "In hóa đơn";
            btn_print_bill.UseVisualStyleBackColor = true;
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
            // lb_total
            // 
            lb_total.Location = new Point(21, 9);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(133, 25);
            lb_total.TabIndex = 4;
            lb_total.Text = "Tổng tiền : ";
            lb_total.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(160, 9);
            label2.Name = "label2";
            label2.Size = new Size(266, 25);
            label2.TabIndex = 5;
            label2.Text = "???";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new Point(211, 34);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 2;
            label1.Text = "?";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lb_table_number
            // 
            lb_table_number.Location = new Point(122, 34);
            lb_table_number.Name = "lb_table_number";
            lb_table_number.Size = new Size(83, 25);
            lb_table_number.TabIndex = 0;
            lb_table_number.Text = "Bàn ăn số :";
            lb_table_number.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frm_tables_manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 645);
            Controls.Add(label2);
            Controls.Add(s);
            Controls.Add(lb_total);
            Controls.Add(btn_pay);
            Controls.Add(label1);
            Controls.Add(btn_print_bill);
            Controls.Add(groupBox_list_option_Pay);
            Controls.Add(lb_table_number);
            Controls.Add(groupBox_tableInfo);
            Controls.Add(groupBox_list_table);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_tables_manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang quản lý bàn ăn";
            groupBox_list_table.ResumeLayout(false);
            groupBox_tableInfo.ResumeLayout(false);
            groupBox_list_option_Pay.ResumeLayout(false);
            groupBox_list_option_Pay.PerformLayout();
            ResumeLayout(false);
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
        private ListView listView1;
        private FlowLayoutPanel flowLayoutPanel_list_table;
        private Label lb_total;
        private Label label2;
        private Label label1;
        private Label lb_table_number;
    }
}