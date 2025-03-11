using System.Collections.Generic;
using TransferObject.TransferObject;

namespace DataLayer.IRepository
{
    public interface IFoodRepository
    {
        IEnumerable<Food> GetAllFoods();  // Lấy tất cả món ăn
        Food GetFoodById(int id);  // Lấy món ăn theo ID
        void AddFood(Food food);   // Thêm món ăn mới
        void UpdateFood(Food food); // Cập nhật món ăn
        void DeleteFood(int id);   // Xóa món ăn
    }
}
