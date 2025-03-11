using System.Collections.Generic;
using TransferObject.TransferObject;

namespace DataLayer.IRepository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();  // Lấy tất cả danh mục
        Category GetCategoryById(int id);  // Lấy danh mục theo ID
        void AddCategory(Category category);   // Thêm danh mục mới
        void UpdateCategory(Category category); // Cập nhật danh mục
        void DeleteCategory(int id);   // Xóa danh mục
    }
}
