using BusinessLayer.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TransferObject.TransferObject;

namespace PresentationLayer
{
    public partial class frm_foods : Form
    {
        private readonly FoodService _foodService;
        private readonly CategoryService _categoryService;

        public frm_foods(FoodService foodService, CategoryService categoryService)
        {
            InitializeComponent();
            _foodService = foodService ?? throw new ArgumentNullException(nameof(foodService));
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));

            tabMenu.SelectedIndexChanged -= TabControl_SelectedIndexChanged;
            tabMenu.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            dgv_listFoodInfo.CellValueChanged += dataGridView1_CellContentClick;

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
                foreach (DataGridViewRow row in dgv_listFoodInfo.Rows)
                {
                    if (row.Cells["Name"].Value?.ToString() == food.Name)
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

                // Nếu chưa có, thêm mới vào DataGridView
                decimal initialTotal = food.Price * 1; // Thành tiền ban đầu = Giá * 1
                dgv_listFoodInfo.Rows.Add(food.Name, food.Price, 1, initialTotal);
            }
        }



        private void listView_listFoodChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu thay đổi ở cột "Quantity"
            if (e.ColumnIndex == dgv_listFoodInfo.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_listFoodInfo.Rows[e.RowIndex];

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
        public delegate void OrderSavedEventHandler(int tableId);
        public event OrderSavedEventHandler OnOrderSaved;

        private void btn_saveOrder_Click(object sender, EventArgs e)
        {

        }
    }
}


//using BusinessLayer.Service;
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Windows.Forms;
//using TransferObject.TransferObject;

//namespace PresentationLayer
//{
//    public partial class frm_foods : Form
//    {
//        private readonly FoodService _foodService;
//        private readonly CategoryService _categoryService;

//        public frm_foods(FoodService foodService, CategoryService categoryService)
//        {
//            InitializeComponent();
//            _foodService = foodService ?? throw new ArgumentNullException(nameof(foodService));
//            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));

//            // Đảm bảo xóa event cũ trước khi đăng ký event mới để tránh bị gọi lại nhiều lần.
//            tabMenu.SelectedIndexChanged -= TabControl_SelectedIndexChanged;
//            tabMenu.SelectedIndexChanged += TabControl_SelectedIndexChanged;

//            InitializeTabs();
//        }

//        private void InitializeTabs()
//        {
//            if (tabMenu == null || tabMenu.TabPages.Count == 0) return; // Kiểm tra tabMenu hợp lệ

//            var categories = _categoryService?.GetAllCategories()?.ToList();
//            if (categories == null || categories.Count == 0) return;

//            foreach (TabPage tabPage in tabMenu.TabPages)
//            {
//                if (tabPage.Tag is not int categoryId) continue; // Kiểm tra nếu tag có giá trị hợp lệ

//                var category = categories.FirstOrDefault(c => c.Id == categoryId);
//                if (category == null) continue; // Nếu không tìm thấy category, bỏ qua

//                if (!tabPage.Controls.OfType<FlowLayoutPanel>().Any()) // Kiểm tra nếu chưa có FlowLayoutPanel thì mới thêm
//                {
//                    var flowLayoutPanel = new FlowLayoutPanel
//                    {
//                        Dock = DockStyle.Fill,
//                        AutoScroll = true,
//                        BackColor = Color.White
//                    };
//                    tabPage.Controls.Add(flowLayoutPanel);
//                }
//            }
//        }

//        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            var selectedTab = tabMenu.SelectedTab;
//            if (selectedTab == null || selectedTab.Tag is not int selectedCategoryId)
//            {
//                MessageBox.Show("Lỗi: Tab không có giá trị hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            LoadFoodButtons(selectedCategoryId);
//        }

//        private void LoadFoodButtons(int categoryId)
//        {
//            if (_foodService == null)
//            {
//                MessageBox.Show("Dịch vụ thực phẩm không khả dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            var selectedTab = tabMenu.SelectedTab;
//            if (selectedTab == null) return;

//            var flowLayoutPanel = selectedTab.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
//            if (flowLayoutPanel == null) return;

//            flowLayoutPanel.Controls.Clear();

//            var foods = _foodService.GetFoodByCategory(categoryId) ?? new List<Food>();
//            if (!foods.Any())
//            {
//                flowLayoutPanel.Controls.Add(new Label { Text = "Không có món ăn nào trong danh mục này.", AutoSize = true, ForeColor = Color.Gray });
//                return;
//            }

//            foreach (var food in foods)
//            {
//                var btnFood = new Button
//                {
//                    Text = $"{food.Name}\n{food.Price:C}",
//                    Width = 150,
//                    Height = 200,
//                    Tag = food.Id,
//                    TextAlign = ContentAlignment.BottomCenter,
//                    BackColor = Color.LightCyan,
//                    FlatStyle = FlatStyle.Flat,
//                    ForeColor = Color.Black
//                };

//                if (!string.IsNullOrEmpty(food.Image) && File.Exists(food.Image))
//                {
//                    try
//                    {
//                        using (var img = new Bitmap(food.Image))
//                        {
//                            btnFood.Image = new Bitmap(img, new Size(150, 110));
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        MessageBox.Show($"Lỗi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                }

//                btnFood.MouseEnter += (s, e) => btnFood.BackColor = Color.LightBlue;
//                btnFood.MouseLeave += (s, e) => btnFood.BackColor = Color.LightCyan;
//                btnFood.Click += BtnFood_Click;

//                flowLayoutPanel.Controls.Add(btnFood);
//            }
//        }

//        private void BtnFood_Click(object sender, EventArgs e)
//        {
//            if (sender is Button btnFood && btnFood.Tag is int foodId)
//            {
//                MessageBox.Show($"Bạn đã chọn món: {btnFood.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//        }
//    }
//}
