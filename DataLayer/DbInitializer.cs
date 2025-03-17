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

           
        }
    }
}
