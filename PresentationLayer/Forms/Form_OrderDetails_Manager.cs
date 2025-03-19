using BusinessLayer.Service;
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
        public frm_orderdetails_manager(FoodService foodService, CategoryService categoryService)
        {
            InitializeComponent();

            _foodService = foodService ?? throw new ArgumentNullException(nameof(foodService));
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));

            tabMenu.SelectedIndexChanged -= TabControl_SelectedIndexChanged;
            tabMenu.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            dgv_listOrder.CellValueChanged += dgv_listOrder_CellContentClick;

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
            if (selectedTab == null) return;

            var flowLayoutPanel = selectedTab.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
            if (flowLayoutPanel == null) return;

            flowLayoutPanel.Controls.Clear(); // Xóa các button cũ

            var foods = _foodService.GetFoodByCategory(categoryId) ?? new List<Food>();

            if (!foods.Any())
            {
                MessageBox.Show("Không có món ăn nào trong danh mục này.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var food in foods)
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

                // Kiểm tra ảnh món ăn
                if (!string.IsNullOrEmpty(food.Image) && File.Exists(food.Image))
                {
                    try
                    {
                        using (var img = Image.FromFile(food.Image))
                        {
                            btnFood.Image = new Bitmap(img, new Size(150, 110));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Hiệu ứng hover
                btnFood.MouseEnter += (s, e) => btnFood.BackColor = Color.LightBlue;
                btnFood.MouseLeave += (s, e) => btnFood.BackColor = Color.LightCyan;

                // Sự kiện click
                btnFood.Click += BtnFood_Click;

                flowLayoutPanel.Controls.Add(btnFood);
            }
        }

        private void BtnFood_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag is int foodId)
            {
                var food = _foodService.GetFoodById(foodId);
                if (food == null) return;

                // Kiểm tra xem món đã tồn tại trong DataGridView chưa
                foreach (DataGridViewRow row in dgv_listOrder.Rows)
                {
                    if (row.Cells["Name"].Value?.ToString() == food.Name && Convert.ToInt32(row.Cells["Id"].Value) == foodId)
                    {
                        // Tăng số lượng
                        int currentQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        row.Cells["Quantity"].Value = currentQuantity + 1;

                        // Cập nhật tổng giá
                        decimal unitPrice = Convert.ToDecimal(row.Cells["Price"].Value);
                        decimal totalPrice = unitPrice * (currentQuantity + 1);
                        row.Cells["Total"].Value = totalPrice; // Cập nhật cột Thành tiền

                        return; // Dừng lại, không thêm mới
                    }
                }

                // Nếu món ăn chưa có trong DataGridView, thêm mới
                decimal initialTotal = food.Price * 1; // Thành tiền ban đầu = Giá * 1
                dgv_listOrder.Rows.Add(food.Name, food.Price, 1, initialTotal, food.Id); // Thêm cột foodId vào

            }
        }
  
        private void btn_saveOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng order hiện tại đang bão trì. Vui lòng chờ trong giây lát.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgv_listOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu thay đổi ở cột "Quantity"
            if (e.ColumnIndex == dgv_listOrder.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_listOrder.Rows[e.RowIndex];

                // Lấy số lượng mới
                if (int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int quantity) && quantity > 0)
                {
                    // Lấy giá món ăn
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                    // Tính lại tổng tiền
                    row.Cells["Total"].Value = price * quantity;
                }
                else
                {
                    // Nếu nhập sai, đặt lại giá trị hợp lệ
                    row.Cells["Quantity"].Value = 1;
                }
            }
        }
    }
}
