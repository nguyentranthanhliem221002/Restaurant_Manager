using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer.Service;
using TransferObject;

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
            LoadTables();
            MessageBox.Show("Show cc");
        }

        private void LoadTables()
        {
            var tables = _tableService.GetAllTables().ToList();

            if (tables.Count == 0)
            {
                MessageBox.Show("Không có bàn nào trong danh sách!");
                return;
            }

            foreach (var table in tables)
            {
                Console.WriteLine($"Bàn {table.Id}: {table.Name} - {table.Status}");
            }
        }

        Color GetMauTrangThai(TableStatus trangThai)
        {
            return trangThai switch
            {
                TableStatus.Available => Color.White,
                TableStatus.Occupied => Color.Yellow,
                TableStatus.Reserved => Color.LightGreen,
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
