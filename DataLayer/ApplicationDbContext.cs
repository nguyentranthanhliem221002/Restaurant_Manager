using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject.Security;
using TransferObject.TransferObject;

namespace DataLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Thiết lập Table Per Type (TPT)
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Customer>().ToTable("Customers");

            // Cấu hình để lưu Enum Role dưới dạng chuỗi trong database
            modelBuilder.Entity<Account>()
                .Property(a => a.Role)
                .HasConversion<string>(); // Chuyển đổi Enum thành string khi lưu vào DB

            // Seed dữ liệu Employee (bao gồm Admin và Staff)
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Admin User", Email = "admin@example.com", Phone = "0123456789", DateOfJoining = DateTime.UtcNow },
                new Employee { Id = 2, Name = "Staff User", Email = "staff@example.com", Phone = "0987654321", DateOfJoining = DateTime.UtcNow }
            );

            // Seed dữ liệu Customer
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 3, Name = "Customer User", Email = "customer@example.com", Phone = "0112233445", LoyaltyPoints = 50 }
            );

            // Seed dữ liệu Account
            modelBuilder.Entity<Account>().HasData(
                new Account { Id = 1, UserName = "admin", PasswordHash = BCrypt.Net.BCrypt.HashPassword("1"), UserId = 1, Role = UserRole.Admin },
                new Account { Id = 2, UserName = "staff", PasswordHash = BCrypt.Net.BCrypt.HashPassword("123"), UserId = 2, Role = UserRole.Staff },
                new Account { Id = 3, UserName = "customer", PasswordHash = BCrypt.Net.BCrypt.HashPassword("0"), UserId = 3, Role = UserRole.Customer }
            );
        }



    }
}
