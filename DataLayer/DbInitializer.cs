using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TransferObject.TransferObject;
using TransferObject.Security;

namespace DataLayer
{
    public class DbInitializer
    {
        public static void SeedData(ApplicationDbContext context)
        {
            context.Database.Migrate(); // Đảm bảo database đã được tạo

            // Seed dữ liệu bàn
            if (!context.Tables.Any())
            {
                var tables = Enumerable.Range(1, 20).Select(i => new Table
                {
                    Name = $"Bàn {i}",
                    Status = TableStatus.Available, // Mặc định là bàn trống
                }).ToList();

                context.Tables.AddRange(tables);
                context.SaveChanges();
                Console.WriteLine("✅ Seed dữ liệu bàn thành công!");
            }
            else
            {
                Console.WriteLine("⚠️ Dữ liệu bàn đã tồn tại, bỏ qua seed!");
            }

            // Seed dữ liệu danh mục (Category)
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Name = "Món Ăn" },
                    new Category { Name = "Đồ Uống" },
                    new Category { Name = "Món Thêm" }
                };

                context.Categories.AddRange(categories);
                context.SaveChanges();
                Console.WriteLine("✅ Seed dữ liệu danh mục thành công!");
            }
            else
            {
                Console.WriteLine("⚠️ Dữ liệu danh mục đã tồn tại, bỏ qua seed!");
            }

            // Lấy danh mục "Món Ăn"
            var foodCategory = context.Categories.FirstOrDefault(c => c.Name == "Món Ăn");
            if (foodCategory != null && !context.Foods.Any())
            {
                var foods = new List<Food>
                {
                    new Food { Name = "Mì Sin Cay", Price = 55, Description = "", CategoryId = foodCategory.Id, Image = "" },
                    new Food { Name = "Mì Soyumm", Price = 45, Description = "", CategoryId = foodCategory.Id, Image = "" },
                    new Food { Name = "Mì Tương Đen", Price = 40, Description = "", CategoryId = foodCategory.Id, Image = "" }
                };

                context.Foods.AddRange(foods);
                context.SaveChanges();
                Console.WriteLine("✅ Seed dữ liệu món ăn thành công!");
            }
            else
            {
                Console.WriteLine("⚠️ Dữ liệu món ăn đã tồn tại hoặc không tìm thấy danh mục 'Món Ăn'!");
            }
        }
    }
}
