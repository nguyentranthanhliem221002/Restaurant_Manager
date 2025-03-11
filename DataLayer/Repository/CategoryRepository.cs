using DataLayer.IRepository;
using Microsoft.EntityFrameworkCore;
using TransferObject.TransferObject;

namespace DataLayer.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Lấy danh sách danh mục + kèm theo danh sách món ăn
        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.Include(c => c.Foods).AsEnumerable();
        }

        // Lấy danh mục theo ID + kèm theo danh sách món ăn
        public Category GetCategoryById(int id)
        {
            return _context.Categories.Include(c => c.Foods).FirstOrDefault(c => c.Id == id);
        }

        // Thêm danh mục mới
        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        // Cập nhật danh mục
        public void UpdateCategory(Category category)
        {
            var existingCategory = _context.Categories.Find(category.Id);
            if (existingCategory != null)
            {
                existingCategory.Name = category.Name;
                _context.SaveChanges();
            }
        }

        // Xóa danh mục (chỉ xóa nếu không có món ăn nào thuộc danh mục đó)
        public void DeleteCategory(int id)
        {
            var category = _context.Categories.Include(c => c.Foods).FirstOrDefault(c => c.Id == id);
            if (category != null && !category.Foods.Any())  // Kiểm tra danh mục có món ăn không
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }
    }
}
