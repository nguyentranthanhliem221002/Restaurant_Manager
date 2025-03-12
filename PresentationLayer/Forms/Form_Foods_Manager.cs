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
        private FoodService foodService;
        private CategoryService categoryService;
        private readonly IServiceProvider _serviceProvider;  // Nhận từ DI

        public frm_foods_manager(FoodService service, CategoryService category, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            this.foodService = service;
            this.categoryService = category;
        }

        private void LoadFoodData()
        {
            var foodList = foodService.GetAllFoods()?.ToList() ?? new List<Food>();
            dgv_listFood.DataSource = foodList;
        }

        private void LoadCategoryData()
        {
            var categoryList = categoryService.GetAllCategories()?.ToList() ?? new List<Category>();
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

            Food food = new Food
            {
                Name = txt_foodName.Text,
                Price = foodPrice,
                CategoryId = (int)comboBox_listCategory.SelectedValue
            };

            foodService.AddFood(food);
            LoadFoodData();
            MessageBox.Show("Thêm món ăn thành công!", "Thông báo");

            txt_foodName.Clear();
            txt_foodPrice.Clear();
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
                foodService.DeleteFood(foodId);
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

                txt_foodName.Text = foodName;
                txt_foodPrice.Text = foodPrice.ToString();
                comboBox_listCategory.SelectedValue = categoryId;

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
            Food food = new Food
            {
                Id = foodId,
                Name = txt_foodName.Text,
                Price = foodPrice,
                CategoryId = (int)comboBox_listCategory.SelectedValue
            };

            foodService.UpdateFood(food);
            LoadFoodData();
            MessageBox.Show("Cập nhật món ăn thành công!", "Thông báo");

            txt_foodName.Clear();
            txt_foodPrice.Clear();
            btn_foodUpdate.Tag = null;
        }

        private void btn_foodSearch_Click(object sender, EventArgs e)
        {
            string keyword = txt_foods_manager_search.Text.Trim().ToLower();
            var foods = foodService.GetAllFoods()?.ToList() ?? new List<Food>();

            var searchResult = string.IsNullOrEmpty(keyword)
                ? foods
                : foods.Where(f => f.Name.ToLower().Contains(keyword)).ToList();

            dgv_listFood.DataSource = null;
            dgv_listFood.DataSource = searchResult;
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
