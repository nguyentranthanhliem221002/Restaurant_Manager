using BusinessLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TransferObject.TransferObject;

namespace PresentationLayer.Forms
{
    public partial class frm_categories_manager : Form
    {
        private readonly CategoryService _categoryService;

        public frm_categories_manager(CategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
        }

        private void LoadCategoryData()
        {
            var categoryList = _categoryService.GetAllCategories()?.ToList() ?? new List<Category>();
            dgv_listCategory.DataSource = categoryList;
        }

        private void frm_categories_manager_Load(object sender, EventArgs e)
        {
            LoadCategoryData();
        }

        private void btn_categoryAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_categoryName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Category category = new Category
            {
                Name = txt_categoryName.Text
            };

            _categoryService.AddCategory(category);
            LoadCategoryData();
            MessageBox.Show("Thêm danh mục thành công!", "Thông báo");

            txt_categoryName.Clear();
            txt_categoryName.Focus();
        }


        private void btn_categoryDelete_Click(object sender, EventArgs e)
        {
            if (dgv_listCategory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một danh mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId = (int)dgv_listCategory.SelectedRows[0].Cells["Id"].Value;
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa danh mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _categoryService.DeleteCategory(categoryId);
                LoadCategoryData();
                MessageBox.Show("Xóa danh mục thành công!", "Thông báo");
            }
        }



        private void btn_categoryFix_Click(object sender, EventArgs e)
        {
            if (dgv_listCategory.SelectedRows.Count > 0)
            {
                int categoryId = (int)dgv_listCategory.SelectedRows[0].Cells["Id"].Value;
                string categoryName = dgv_listCategory.SelectedRows[0].Cells["Name"].Value.ToString();

                txt_categoryName.Text = categoryName;
                btn_categoryUpdate.Tag = categoryId;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một danh mục để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_categoryUpdate_Click(object sender, EventArgs e)
        {
            if (btn_categoryUpdate.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn một danh mục để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_categoryName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int categoryId = (int)btn_categoryUpdate.Tag;
            Category category = new Category
            {
                Id = categoryId,
                Name = txt_categoryName.Text
            };

            _categoryService.UpdateCategory(category);
            LoadCategoryData();
            MessageBox.Show("Cập nhật danh mục thành công!", "Thông báo");

            txt_categoryName.Clear();
            btn_categoryUpdate.Tag = null;
        }

        private void btn_categorySearch_Click(object sender, EventArgs e)
        {
            string keyword = txt_categories_manager_search.Text.Trim().ToLower();
            var categories = _categoryService.GetAllCategories()?.ToList() ?? new List<Category>();

            var searchResult = string.IsNullOrEmpty(keyword)
                ? categories
                : categories.Where(c => c.Name.ToLower().Contains(keyword)).ToList();

            dgv_listCategory.DataSource = null;
            dgv_listCategory.DataSource = searchResult;
        }


    }
}
