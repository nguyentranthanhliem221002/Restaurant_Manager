using BusinessLayer.Service;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frm_register : Form
    {
        private readonly IServiceProvider _serviceProvider;  // Nhận từ DI
        public frm_register(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

        }

        private void linkLabel_register_toLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            var context = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var tableService = _serviceProvider.GetRequiredService<TableService>();
            var foodService = _serviceProvider.GetRequiredService<FoodService>();
            var categoryService = _serviceProvider.GetRequiredService<CategoryService>();
            var employeeService = _serviceProvider.GetRequiredService<EmployeeService>();

            frm_login frm_Login = new frm_login(context, tableService, foodService, categoryService, employeeService, _serviceProvider);
            frm_Login.Show();
        }
    }
}
