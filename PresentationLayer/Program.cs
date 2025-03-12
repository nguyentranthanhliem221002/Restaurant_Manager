//namespace PresentationLayer;

//static class Program
//{
//    /// <summary>
//    ///  The main entry point for the application.
//    /// </summary>
//    [STAThread]
//    static void Main()
//    {
//        // To customize application configuration such as set high DPI settings or default font,
//        // see https://aka.ms/applicationconfiguration.
//        ApplicationConfiguration.Initialize();
//        Application.Run(new frm_main());
//    }    
//}

using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using DataLayer; // Chứa ApplicationDbContext
using BusinessLayer.Service; // Chứa các Services
using PresentationLayer.Forms; // Chứa các Forms
using DataLayer.IRepository;
using DataLayer.Repository;
using System.IO;

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
                using (var scope = serviceProvider.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    dbContext.Database.Migrate(); // Tạo Database nếu chưa có
                }

                // Mở form login trước
                var loginForm = serviceProvider.GetRequiredService<frm_login>();
                if (loginForm.ShowDialog() == DialogResult.OK) // Nếu đăng nhập thành công
                {
                    // Mở form chính sau khi đăng nhập
                    Application.Run(serviceProvider.GetRequiredService<frm_main>());
                }
            }
        }

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
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ITableRepository, TableRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();

            // Đăng ký Service
            services.AddScoped<RoleService>();
            services.AddScoped<FoodService>();
            services.AddScoped<CategoryService>();
            services.AddScoped<CustomerService>();
            services.AddScoped<EmployeeService>();
            services.AddScoped<TableService>();
            services.AddScoped<OrderService>();
            services.AddScoped<OrderDetailService>();

            // Đăng ký Forms với DI
            services.AddTransient<frm_roles_manager>(); 
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
    }
}
