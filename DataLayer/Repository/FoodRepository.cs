using DataLayer.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TransferObject.TransferObject;

namespace DataLayer.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private readonly ApplicationDbContext _context;

        public FoodRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Lấy danh sách món ăn + bao gồm cả danh mục
        public IQueryable<Food> GetAllFoods()
        {
            return _context.Foods.Include(f => f.Category);  // Trả về IQueryable thay vì IEnumerable
        }

        // Lấy món ăn theo ID + bao gồm cả danh mục
        public Food GetFoodById(int id) => _context.Foods.Include(f => f.Category).FirstOrDefault(f => f.Id == id);
      

        // Lấy danh sách món ăn theo loại
        public IQueryable<Food> GetFoodsByCategory(int categoryId)
        {
            return _context.Foods
                .Include(f => f.Category)
                .Where(f => f.CategoryId == categoryId);  // Trả về IQueryable
        }

        // Thêm món ăn mới
        public void AddFood(Food food)
        {
            _context.Foods.Add(food);
            _context.SaveChanges();
        }

        // Cập nhật món ăn
        public void UpdateFood(Food food)
        {
            var existingFood = _context.Foods.Find(food.Id);
            if (existingFood != null)
            {
                existingFood.Name = food.Name;
                existingFood.Price = food.Price;
                existingFood.Image = food.Image;
                existingFood.Description = food.Description;
                existingFood.CategoryId = food.CategoryId;

                _context.SaveChanges();
            }
        }

        // Xóa món ăn
        public void DeleteFood(int id)
        {
            var food = _context.Foods.Find(id);
            if (food != null)
            {
                _context.Foods.Remove(food);
                _context.SaveChanges();
            }
        }
    }
}
