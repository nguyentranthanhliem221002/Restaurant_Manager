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

            InitializeTabs();
        }

        private void InitializeTabs()
        {
            tabMenu.TabPages.Clear();
            var categories = _categoryService.GetAllCategories()?.ToList() ?? new List<Category>();

            foreach (var category in categories)
            {
                var tabPage = new TabPage(category.Name) { Tag = category.Id };
                var flowLayoutPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.None,
                    Width = 777,
                    Height = 777,
                    AutoScroll = true, // Duyệt danh sách món ăn nếu quá nhiều
                    BackColor = Color.White
                };

                tabPage.Controls.Add(flowLayoutPanel);
                tabMenu.TabPages.Add(tabPage);
            }

            if (tabMenu.TabPages.Count > 0)
            {
                tabMenu.SelectedIndex = 0;
                LoadFoodButtons(categories.First().Id);
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMenu.SelectedTab == null) return;
            int selectedCategoryId = (int)tabMenu.SelectedTab.Tag;
            LoadFoodButtons(selectedCategoryId);
        }

        private void LoadFoodButtons(int categoryId)
        {
            if (_foodService == null)
            {
                MessageBox.Show("Lỗi: Không thể tải danh sách món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedTab = tabMenu.SelectedTab;
            if (selectedTab == null || selectedTab.Controls.Count == 0 || !(selectedTab.Controls[0] is FlowLayoutPanel flowLayoutPanel))
            {
                return;
            }

            flowLayoutPanel.Controls.Clear();
            var foods = _foodService.GetFoodByCategory(categoryId) ?? new List<Food>();

            if (!foods.Any())
            {
                MessageBox.Show("Không có món ăn nào trong danh mục này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                btnFood.MouseEnter += (s, e) => btnFood.BackColor = Color.LightBlue;
                btnFood.MouseLeave += (s, e) => btnFood.BackColor = Color.LightCyan;
                btnFood.Click += BtnFood_Click;

                flowLayoutPanel.Controls.Add(btnFood);
            }
        }

        private void BtnFood_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag is int foodId)
            {
                MessageBox.Show($"Bạn đã chọn món: {clickedButton.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
