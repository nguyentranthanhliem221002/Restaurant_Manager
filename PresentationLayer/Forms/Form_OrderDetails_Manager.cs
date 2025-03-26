using BusinessLayer.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject.TransferObject;

namespace PresentationLayer.Forms
{
    public partial class frm_orderdetails_manager : Form
    {
        private readonly FoodService _foodService;
        private readonly CategoryService _categoryService;
        private readonly TableService _tableService;
        private readonly OrderService _orderService;
        private readonly IServiceProvider _serviceProvider;

        private int _tableId;

        private void frm_orderdetails_manager_Load(object sender, EventArgs e)
        {

        }
        // Phương thức này sẽ được gọi từ frm_tables_manager
        public void SetTableId(int tableId)
        {
            _tableId = tableId;
            if (lb_orderNumber != null)
            {
                lb_orderNumber.Text = $"Bàn số: {tableId}";
            }

        }
        public frm_orderdetails_manager(FoodService foodService, CategoryService categoryService, TableService tableService, OrderService orderService, IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _foodService = foodService ?? throw new ArgumentNullException(nameof(foodService));
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
            _tableService = tableService ?? throw new ArgumentNullException(nameof(tableService));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));


            tabMenu.SelectedIndexChanged -= TabControl_SelectedIndexChanged;
            tabMenu.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            dgv_listOrderDetail.CellValueChanged += dgv_listOrder_CellContentClick;

            InitializeTabs();
        }
        private void InitializeTabs()
        {
            var categories = _categoryService.GetAllCategories()?.ToList() ?? new List<Category>();

            if (tabMenu.TabPages.Count < categories.Count)
            {
                MessageBox.Show("Số lượng TabPage không đủ, hãy thêm đủ TabPage trong giao diện thiết kế!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < categories.Count; i++)
            {
                var category = categories[i];
                var tabPage = tabMenu.TabPages[i];

                tabPage.Text = category.Name;
                tabPage.Tag = category.Id; // Gán ID danh mục vào Tag để dùng sau

                // Kiểm tra nếu FlowLayoutPanel đã tồn tại, nếu chưa thì thêm mới
                var flowLayoutPanel = tabPage.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                if (flowLayoutPanel == null)
                {
                    flowLayoutPanel = new FlowLayoutPanel
                    {
                        Size = new Size(666, 666), // Thiết lập kích thước cố định
                        AutoScroll = true,
                        BackColor = Color.Turquoise,
                        Anchor = AnchorStyles.Top | AnchorStyles.Left // Giữ vị trí ở góc trái trên
                    };
                    tabPage.Controls.Add(flowLayoutPanel);
                }
            }

            if (tabMenu.TabPages.Count > 0)
            {
                tabMenu.SelectedIndex = 0;
                LoadFoodButtons((int)tabMenu.TabPages[0].Tag);
            }
        }


        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMenu.SelectedTab == null || tabMenu.SelectedTab.Tag == null)
                return;

            int selectedCategoryId = (int)tabMenu.SelectedTab.Tag;
            LoadFoodButtons(selectedCategoryId);
        }


        private void LoadFoodButtons(int categoryId)
        {
            var selectedTab = tabMenu.SelectedTab;
            var flowLayoutPanel = selectedTab?.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
            if (flowLayoutPanel == null) return;

            flowLayoutPanel.Controls.Clear();

            var foods = _foodService.GetFoodByCategory(categoryId) ?? new List<Food>();
            if (!foods.Any())
            {
                MessageBox.Show("Không có món ăn nào trong danh mục này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var food in foods)
            {
                var btnFood = CreateFoodButton(food);
                flowLayoutPanel.Controls.Add(btnFood);
            }
        }
        private Button CreateFoodButton(Food food)
        {
            var btnFood = new Button
            {
                Text = $"{food.Name}\n{food.Price:C}",
                Width = 150,
                Height = 200,
                Tag = food.Id,
                TextAlign = ContentAlignment.BottomCenter,
                BackColor = Color.LightCyan,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Black
            };

            if (!string.IsNullOrEmpty(food.Image) && File.Exists(food.Image))
            {
                try
                {
                    using var img = Image.FromFile(food.Image);
                    btnFood.Image = new Bitmap(img, new Size(150, 110));
                }
                catch { /* Bỏ qua lỗi hình ảnh */ }
            }

            btnFood.MouseEnter += (s, e) => btnFood.BackColor = Color.LightBlue;
            btnFood.MouseLeave += (s, e) => btnFood.BackColor = Color.LightCyan;
            btnFood.Click += BtnFood_Click;

            return btnFood;
        }
        private void BtnFood_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag is int foodId)
            {
                var food = _foodService.GetFoodById(foodId);
                if (food == null) return;

                foreach (DataGridViewRow row in dgv_listOrderDetail.Rows)
                {
                    if (row.Cells["Name"].Value?.ToString() == food.Name)
                    {
                        row.Cells["Quantity"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) + 1;
                        row.Cells["SubTotal"].Value = Convert.ToDecimal(row.Cells["Price"].Value) * Convert.ToInt32(row.Cells["Quantity"].Value);
                        return;
                    }
                }

                dgv_listOrderDetail.Rows.Add(food.Name, food.Price, 1, food.Price, food.Id);
            }
        }


        private void btn_saveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách chi tiết đơn hàng từ DataGridView
                var orderDetails = dgv_listOrderDetail.Rows.Cast<DataGridViewRow>()
                    .Where(row => !row.IsNewRow) // Loại bỏ dòng trống
                    .Select(row => new OrderDetail
                    {
                        FoodName = row.Cells["Name"].Value?.ToString() ?? "Không xác định", // Tránh null
                        Price = row.Cells["Price"].Value != null ? Convert.ToDecimal(row.Cells["Price"].Value) : 0,
                        Quantity = row.Cells["Quantity"].Value != null ? Convert.ToInt32(row.Cells["Quantity"].Value) : 1,
                        Total = row.Cells["SubTotal"].Value != null ? Convert.ToDecimal(row.Cells["SubTotal"].Value) : 0,
                        FoodId = row.Cells["Id"].Value != null ? Convert.ToInt32(row.Cells["Id"].Value) : 0
                    })
                    .ToList();

                // Kiểm tra nếu không có sản phẩm nào
                if (!orderDetails.Any())
                {
                    MessageBox.Show("Không có đơn hàng nào để lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy UserId từ SessionManager
                int userId = SessionManager.CurrentUserId;
                //MessageBox.Show($"UserId hiện tại: {SessionManager.CurrentUserId}");

                if (userId <= 0)
                {
                    MessageBox.Show("Lỗi: Không tìm thấy UserId! Vui lòng đăng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra TableId hợp lệ trước khi lưu
                if (_tableId <= 0)
                {
                    MessageBox.Show("Lỗi: Không tìm thấy TableId hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lưu đơn hàng
                _orderService.SaveOrder(_tableId, userId, orderDetails);

                // Thông báo thành công
                MessageBox.Show("Lưu đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật trạng thái bàn
                _tableService.UpdateTableStatus(_tableId, TableStatus.Occupied);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}\nChi tiết lỗi: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void LoadExistingOrderDetails(List<OrderDetail> orderDetails)
        {
            dgv_listOrderDetail.Rows.Clear();
            orderDetails.ForEach(detail => dgv_listOrderDetail.Rows.Add(detail.FoodName, detail.Price, detail.Quantity, detail.Total, detail.FoodId));
        }
        public void ClearOrderDetails() => dgv_listOrderDetail.Rows.Clear();

        private void dgv_listOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_listOrderDetail.Columns["Quantity"].Index)
            {
                var row = dgv_listOrderDetail.Rows[e.RowIndex];
                if (int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int quantity) && quantity > 0)
                {
                    row.Cells["SubTotal"].Value = Convert.ToDecimal(row.Cells["Price"].Value) * quantity;
                }
                else
                {
                    row.Cells["Quantity"].Value = 1;
                }
            }
        }
    }
}
