using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private readonly OrderService _orderService;
        private const string TableImagePath = "D:\\Restaurant_Manager\\Imgs\\img_table.png";

        public frm_tables_manager(TableService tableService, IServiceProvider serviceProvider, OrderService orderService)
        {
            InitializeComponent();
            _tableService = tableService ?? throw new ArgumentNullException(nameof(tableService));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
        }

        private void frm_tables_manager_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Đang load danh sách bàn...");
            LoadTables();
        }

        private void LoadTables()
        {
            var tables = _tableService.GetAllTables().ToList();
            flowLayoutPanel_list_table.Controls.Clear();
            flowLayoutPanel_list_table.Visible = true;
            flowLayoutPanel_list_table.AutoScroll = true;

            if (!tables.Any())
            {
                MessageBox.Show("Không có bàn nào trong danh sách!");
                return;
            }

            foreach (var table in tables)
            {
                flowLayoutPanel_list_table.Controls.Add(CreateTableButton(table));
            }
        }

        private Button CreateTableButton(Table table)
        {
            var btn_table = new Button
            {
                Width = 100,
                Height = 100,
                Text = table.Name,
                Tag = table.Id,
                BackColor = GetTableColor(table.Status),
                Font = new Font("Arial", 10, FontStyle.Bold),
                ContextMenuStrip = CreateTableContextMenu(table.Id)
            };

            if (File.Exists(TableImagePath))
            {
                btn_table.BackgroundImage = Image.FromFile(TableImagePath);
            }

            btn_table.Click += (sender, e) => HandleTableClick(table.Id);
            return btn_table;
        }

        private ContextMenuStrip CreateTableContextMenu(int tableId)
        {
            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Order", null, (s, e) => OpenOrderForm(tableId));
            contextMenu.Items.Add("Thông tin bàn ăn", null, (s, e) => ShowTableInfo(tableId));
            return contextMenu;
        }

        private void HandleTableClick(int tableId)
        {
            MessageBox.Show($"Bạn đã chọn bàn có ID: {tableId}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenOrderForm(int tableId)
        {
            var existingOrders = _orderService.GetOrderDetailsByTableId(tableId).ToList();
            var frmMain = Application.OpenForms.OfType<frm_main>().FirstOrDefault();
            if (frmMain == null) return;

            var frmOrderDetail = _serviceProvider.GetRequiredService<frm_orderdetails_manager>();
            frmOrderDetail.SetTableId(tableId);

            if (existingOrders.Any())
            {
                frmOrderDetail.LoadExistingOrderDetails(existingOrders);
            }

            frmMain.OpenChildForm(frmOrderDetail);
        }
        //private void OpenOrderForm(int tableId)
        //{
        //    var frmOrderDetail = _serviceProvider.GetRequiredService<frm_orderdetails_manager>();

        //    // Đặt ID của bàn
        //    frmOrderDetail.SetTableId(tableId);

        //    // Nếu có đơn hàng cũ, load dữ liệu vào form
        //    var existingOrders = _orderService.GetOrderDetailsByTableId(tableId).ToList();
        //    frmOrderDetail.LoadExistingOrderDetails(existingOrders);

        //    // Mở form OrderDetails
        //    frmOrderDetail.Show();
        //}
        public void UpdateTableColor(int tableId, Color color)
        {
            var button = flowLayoutPanel_list_table.Controls.OfType<Button>().FirstOrDefault(btn => (int)btn.Tag == tableId);
            button?.Invoke(new Action(() => button.BackColor = color));
        }

        public Color GetTableColor(TableStatus status) => status switch
        {
            TableStatus.Occupied => Color.Red,
            TableStatus.Available => Color.Green,
            TableStatus.Reserved => Color.Orange,
            _ => Color.Gray
        };

        private string GetTableStatusText(TableStatus status) => status switch
        {
            TableStatus.Occupied => "Đang có khách",
            TableStatus.Available => "Bàn trống",
            TableStatus.Reserved => "Đã đặt trước",
            _ => "Không xác định"
        };

        private void btn_print_bill_Click(object sender, EventArgs e) => MessageBox.Show("Chức năng in hóa đơn");

        private void btn_pay_Click(object sender, EventArgs e)
        {
            var occupiedTable = _tableService.GetAllTables().FirstOrDefault(t => t.Status == TableStatus.Occupied);

            if (occupiedTable == null)
            {
                MessageBox.Show("Không có bàn nào có khách để thanh toán.");
                return;
            }

            _tableService.UpdateTableStatus(occupiedTable.Id, TableStatus.Available);
            UpdateTableColor(occupiedTable.Id, Color.Green);
            _orderService.DeleteOrdersByTableId(occupiedTable.Id);

            listView_listTableChoose.Items.Clear();
            Application.OpenForms.OfType<frm_orderdetails_manager>().FirstOrDefault()?.ClearOrderDetails();

            MessageBox.Show($"Bàn {occupiedTable.Id} đã thanh toán, trở thành bàn trống.");
        }

        private void ShowTableInfo(int tableId)
        {
            var table = _tableService.GetTableById(tableId);
            if (table == null)
            {
                MessageBox.Show("Không tìm thấy thông tin bàn ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lb_tableNumber.Text = $"Bàn số: {table.Id}";
            lb_tableStatus.Text = $"Trạng thái: {GetTableStatusText(table.Status)}";
            listView_listTableChoose.Items.Clear();

            var orderDetails = _orderService.GetOrderDetailsByTableId(tableId).ToList();

            if (!orderDetails.Any() || table.Status == TableStatus.Available)
            {
                MessageBox.Show("Bàn này đã thanh toán hoặc chưa có món ăn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal total = 0;
            foreach (var order in orderDetails)
            {
                var listItem = new ListViewItem(order.FoodName)
                {
                    SubItems = { order.Quantity.ToString(), order.Price.ToString(), (order.Quantity * order.Price).ToString() }
                };
                listView_listTableChoose.Items.Add(listItem);
                total += order.Quantity * order.Price;
            }

            lb_subTotal.Text = $"Tổng tiền: {total}";
        }

    
    }
}