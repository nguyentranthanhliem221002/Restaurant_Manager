using BusinessLayer.Service;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Forms;
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

namespace PresentationLayer
{
    public partial class frm_foods_manager : Form
    {
        private FoodService _foodService;
        private CategoryService _categoryService;
        private readonly IServiceProvider _serviceProvider;  // Nhận từ DI

        public frm_foods_manager(FoodService foodService, CategoryService categoryService, IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _foodService = foodService ?? throw new ArgumentNullException(nameof(foodService));
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

        }

        private void LoadFoodData()
        {
            var foodList = _foodService.GetAllFoods()?.ToList() ?? new List<Food>();
            dgv_listFood.DataSource = foodList;
        }

        private void LoadCategoryData()
        {
            var categoryList = _categoryService.GetAllCategories()?.ToList() ?? new List<Category>();
            comboBox_listCategory.DataSource = categoryList;
            comboBox_listCategory.DisplayMember = "Name";
            comboBox_listCategory.ValueMember = "Id";
        }

        private void frm_foods_manager_Load(object sender, EventArgs e)
        {
            LoadFoodData();

            LoadCategoryData();
        }

        private void btn_foodAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_foodName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txt_foodPrice.Text, out decimal foodPrice))
            {
                MessageBox.Show("Giá món ăn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pictureBox_upload.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string imagePath = pictureBox_upload.Tag.ToString(); // Lấy đường dẫn ảnh

            Food food = new Food
            {
                Name = txt_foodName.Text,
                Price = foodPrice,
                CategoryId = (int)comboBox_listCategory.SelectedValue,
                Image = imagePath // Lưu đường dẫn ảnh
            };

            _foodService.AddFood(food);
            LoadFoodData();
            MessageBox.Show("Thêm món ăn thành công!", "Thông báo");

            txt_foodName.Clear();
            txt_foodPrice.Clear();
            pictureBox_upload.Image = null;
            pictureBox_upload.Tag = null;
            txt_foodName.Focus();
        }

        private void btn_foodDelete_Click(object sender, EventArgs e)
        {
            if (dgv_listFood.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một món ăn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int foodId = (int)dgv_listFood.SelectedRows[0].Cells["Id"].Value;
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa món ăn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _foodService.DeleteFood(foodId);
                LoadFoodData();
                MessageBox.Show("Xóa món ăn thành công!", "Thông báo");
            }
        }

        private void btn_foodFix_Click(object sender, EventArgs e)
        {
            if (dgv_listFood.SelectedRows.Count > 0) // Kiểm tra có dòng nào được chọn không
            {
                int foodId = (int)dgv_listFood.SelectedRows[0].Cells["Id"].Value;
                string foodName = dgv_listFood.SelectedRows[0].Cells["Name"].Value.ToString();
                decimal foodPrice = (decimal)dgv_listFood.SelectedRows[0].Cells["Price"].Value;
                int categoryId = (int)dgv_listFood.SelectedRows[0].Cells["CategoryId"].Value;
                string imagePath = dgv_listFood.SelectedRows[0].Cells["Image"].Value?.ToString();

                txt_foodName.Text = foodName;
                txt_foodPrice.Text = foodPrice.ToString();
                comboBox_listCategory.SelectedValue = categoryId;

                // Hiển thị ảnh lên PictureBox nếu có
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBox_upload.Image = Image.FromFile(imagePath);
                    pictureBox_upload.Tag = imagePath; // Lưu lại đường dẫn ảnh
                }
                else
                {
                    pictureBox_upload.Image = null;
                    pictureBox_upload.Tag = null;
                }

                btn_foodUpdate.Tag = foodId;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_foodUpdate_Click(object sender, EventArgs e)
        {
            if (btn_foodUpdate.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn một món ăn để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_foodName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txt_foodPrice.Text, out decimal foodPrice))
            {
                MessageBox.Show("Giá món ăn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int foodId = (int)btn_foodUpdate.Tag;

            // Lấy đường dẫn ảnh, nếu không chọn ảnh mới thì giữ nguyên ảnh cũ
            string imagePath = pictureBox_upload.Tag?.ToString() ?? dgv_listFood.SelectedRows[0].Cells["Image"].Value?.ToString();

            Food food = new Food
            {
                Id = foodId,
                Name = txt_foodName.Text,
                Price = foodPrice,
                CategoryId = (int)comboBox_listCategory.SelectedValue,
                Image = imagePath // Cập nhật đường dẫn ảnh
            };

            _foodService.UpdateFood(food);
            LoadFoodData();
            MessageBox.Show("Cập nhật món ăn thành công!", "Thông báo");

            txt_foodName.Clear();
            txt_foodPrice.Clear();
            pictureBox_upload.Image = null;
            pictureBox_upload.Tag = null;
            btn_foodUpdate.Tag = null;
        }

        private void btn_foodSearch_Click(object sender, EventArgs e)
        {
            string keyword = txt_foods_manager_search.Text.Trim().ToLower();
            var foods = _foodService.GetAllFoods()?.ToList() ?? new List<Food>();

            var searchResult = string.IsNullOrEmpty(keyword)
                ? foods
                : foods.Where(f => f.Name.ToLower().Contains(keyword)).ToList();

            dgv_listFood.DataSource = null;
            dgv_listFood.DataSource = searchResult;
        }

        private void btn_foodImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh món ăn";
                openFileDialog.Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        // Giải phóng tài nguyên ảnh cũ (nếu có) trước khi tải ảnh mới
                        if (pictureBox_upload.Image != null)
                        {
                            pictureBox_upload.Image.Dispose();
                        }

                        // Tải ảnh mới vào PictureBox
                        pictureBox_upload.Image = Image.FromFile(filePath);
                        pictureBox_upload.Tag = filePath; // Lưu đường dẫn ảnh
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không thể tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void dgv_listFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_categories_manager_Click(object sender, EventArgs e)
        {
            var frmMain = Application.OpenForms.OfType<frm_main>().FirstOrDefault();
            if (frmMain != null)
            {
                var frmCategoriesManager = _serviceProvider.GetRequiredService<frm_categories_manager>();
                frmMain.OpenChildForm(frmCategoriesManager);
            }
        }
    }
}
