using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer.Service;
using TransferObject.TransferObject;

namespace PresentationLayer.Forms
{
    public partial class frm_tables_manager : Form
    {
        private readonly TableService _tableService;

        public frm_tables_manager(TableService tableService)
        {
            InitializeComponent();
            _tableService = tableService;
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
                // Tạo button cho từng bàn
                Button btn_table = new Button
                {
                    Width = 100, // Chiều rộng của button
                    Height = 100, // Chiều cao của button
                    Text = $"Bàn {table.Id}\n{table.Name}", // Hiển thị tên bàn
                    Tag = table.Id, // Lưu ID bàn vào tag
                    BackColor = GetMauTrangThai(table.Status), // Màu theo trạng thái
                    Font = new Font("Arial", 10, FontStyle.Bold)
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
            int banId = (int)clickedButton.Tag;

            MessageBox.Show($"Bạn đã chọn bàn {banId}", "Thông tin bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    
    }
}
