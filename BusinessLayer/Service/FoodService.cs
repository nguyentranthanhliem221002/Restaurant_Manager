using DataLayer.IRepository;
using System.Collections.Generic;
using TransferObject.TransferObject;

namespace BusinessLayer.Service
{
    public class FoodService
    {
        private readonly IFoodRepository _foodRepository;

      
        public FoodService(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        
        public IEnumerable<Food> GetAllFoods()
        {
            return _foodRepository.GetAllFoods();
        }

        public Food GetFoodById(int id)
        {
            return _foodRepository.GetFoodById(id);
        }
        public IEnumerable<Food> GetFoodByCategory(int categoryId)
        {
            return _foodRepository.GetFoodsByCategory(categoryId);
        }

        public void AddFood(Food food)
        {
            _foodRepository.AddFood(food);
        }

        public void UpdateFood(Food food)
        {
            _foodRepository.UpdateFood(food);
        }

        public void DeleteFood(int id)
        {
            _foodRepository.DeleteFood(id);
        }
    }
}
