using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataLayer; // Chứa ApplicationDbContext
using BusinessLayer.Service; // Chứa các Services
using PresentationLayer.Forms; // Chứa các Forms
using DataLayer.IRepository;
using DataLayer.Repository;

namespace PresentationLayer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                // Khởi tạo Database (Migrate + SeedData)
                InitializeDatabase(serviceProvider);

                // Mở form login trước
                var loginForm = serviceProvider.GetRequiredService<frm_login>();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Nếu đăng nhập thành công, mở form chính
                        Application.Run(serviceProvider.GetRequiredService<frm_main>());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"❌ Error when opening the main form: {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Cấu hình dịch vụ và Dependency Injection (DI)
        /// </summary>
        private static void ConfigureServices(IServiceCollection services)
        {
            // Đọc ConnectionString từ appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            // Đăng ký DbContext với SQL Server
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString), ServiceLifetime.Scoped);

            // Đăng ký Repository
            services.AddScoped<IFoodRepository, FoodRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ITableRepository, TableRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();

            // Đăng ký Service
            services.AddScoped<FoodService>();
            services.AddScoped<CategoryService>();
            services.AddScoped<CustomerService>();
            services.AddScoped<EmployeeService>();
            services.AddScoped<TableService>();
            services.AddScoped<OrderService>();
            services.AddScoped<OrderDetailService>();

            // Đăng ký Forms với DI
            services.AddTransient<frm_login>();
            services.AddTransient<frm_main>();
            services.AddTransient<frm_foods_manager>();
            services.AddTransient<frm_categories_manager>();
            services.AddTransient<frm_customers_manager>();
            services.AddTransient<frm_employees_manager>();
            services.AddTransient<frm_tables_manager>();
            services.AddTransient<frm_orders_manager>();
            services.AddTransient<frm_orderdetails_manager>();
        }

        /// <summary>
        /// Khởi tạo database, chạy Migration và SeedData nếu cần
        /// </summary>
        private static void InitializeDatabase(ServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                try
                {
                    dbContext.Database.Migrate();
                    Console.WriteLine("✅ Database migration completed!");

                    DbInitializer.SeedData(dbContext);
                    Console.WriteLine("✅ Seeding data completed!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Error during migration or seeding: {ex.Message}");
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine($"👉 Inner Exception: {ex.InnerException.Message}");
                    }
                }
            }
        }



    }
}
