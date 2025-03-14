using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer.Service;
using Microsoft.Extensions.DependencyInjection;
using TransferObject.TransferObject;

namespace PresentationLayer.Forms
{
    public partial class frm_tables_manager : Form
    {
        private readonly TableService _tableService;
        private readonly IServiceProvider _serviceProvider;

        public frm_tables_manager(TableService tableService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _tableService = tableService ?? throw new ArgumentNullException(nameof(tableService));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        private void frm_tables_manager_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Đang load danh sách bàn..."); // Kiểm tra xem có chạy không
            LoadTables();
        }

        private void LoadTables()
        {
            // Lấy danh sách bàn từ database
            var tables = _tableService.GetAllTables().ToList();

            // Xóa các button cũ trước khi load mới
            flowLayoutPanel_list_table.Controls.Clear();

            if (tables.Count == 0)
            {
                MessageBox.Show("Không có bàn nào trong danh sách!");
                return;
            }

            foreach (var table in tables)
            {
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                contextMenu.Items.Add("Xem chi tiết", null, (s, e) => MessageBox.Show("Chi tiết bàn"));
                contextMenu.Items.Add("Xóa bàn", null, (s, e) => MessageBox.Show("Xóa bàn thành công"));
                // Tạo button cho từng bàn
                Button btn_table = new Button
                {
                    Width = 100, // Chiều rộng của button
                    Height = 100, // Chiều cao của button
                    //Text = $"Bàn {table.Id}\n{table.Name}", // Hiển thị tên bàn
                    Text = table.Name, // Hiển thị tên bàn

                    Tag = table.Id, // Lưu ID bàn vào tag
                    BackColor = GetMauTrangThai(table.Status), // Màu theo trạng thái
                    BackgroundImage = Image.FromFile("D:\\Restaurant_Manager\\Imgs\\img_table.png"),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ContextMenuStrip = contextMenu // Gán context menu vào button

                };

                // Gán sự kiện Click
                btn_table.Click += BtnBan_Click;

                // Thêm button vào flowLayoutPanel
              

                flowLayoutPanel_list_table.Controls.Add(btn_table);
                flowLayoutPanel_list_table.Visible = true; // Đảm bảo panel hiển thị
                flowLayoutPanel_list_table.AutoScroll = true; // Bật cuộn nếu cần
            }
        }

        Color GetMauTrangThai(TableStatus trangThai)
        {
            return trangThai switch
            {
                TableStatus.Available => Color.White,       // Bàn trống
                TableStatus.Occupied => Color.Yellow,       // Bàn đang có khách
                TableStatus.Reserved => Color.LightGreen,   // Bàn đã đặt trước
                _ => Color.Gray
            };
        }

        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            int banId = (int)clickedButton.Tag;
            Color currentColor = clickedButton.BackColor;

            // Kiểm tra nếu bàn có màu trắng (bàn trống)
            if (currentColor == Color.White)
            {
                // Mở form `frm_foods`
               
                var frmMain = Application.OpenForms.OfType<frm_main>().FirstOrDefault();
                if (frmMain != null)
                {
                    var frmFoods = _serviceProvider.GetRequiredService<frm_foods>();
                    frmMain.OpenChildForm(frmFoods);
                }
            }
            else
            {
                MessageBox.Show($"Bàn {banId} không trống, không thể đặt món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

 

        private void btn_pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng thanh toán hiện tại đang bão trì. Vui lòng chờ trong giây lát.");
        }

        private void btn_print_bill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng in hóa đơn hiện tại đang bão trì. Vui lòng chờ trong giây lát.");
        }
        
    }
}
