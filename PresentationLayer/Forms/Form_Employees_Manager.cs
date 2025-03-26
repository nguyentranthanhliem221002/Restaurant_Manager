using BusinessLayer.Service;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TransferObject.TransferObject;

namespace PresentationLayer
{
    public partial class frm_employees_manager : Form
    {
        private EmployeeService _employeeService;
        private readonly IServiceProvider _serviceProvider;

        public frm_employees_manager(EmployeeService employeeService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this._employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
            this._serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        private void LoadData()
        {
            // Load danh sách nhân viên
            dgv_listEmployee.DataSource = _employeeService.GetAllEmployees()?.ToList() ?? new List<Employee>();
            var roles = _employeeService.GetAllRoles() ?? new List<string>();

            comboBox_listLevel.DataSource = roles;
            comboBox_listLevel.DisplayMember = ""; // Không đặt DisplayMember vì dữ liệu là List<string>

        }

        private void frm_employees_manager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_employeeAdd_Click(object sender, EventArgs e)
        {
            string employeeName = txt_employeeName.Text.Trim();
            string phone = txt_employeePhone.Text.Trim();

            if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dateOfJoining = dateTimePicker_employees_manager_startDate.Value;

            Employee employee = new Employee
            {
                Name = employeeName,
                Phone = phone,
                DateOfJoining = dateOfJoining
            };

            _employeeService.AddEmployee(employee);
            LoadData();
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");

            txt_employeeName.Clear();
            txt_employeePhone.Clear();
            txt_employeeName.Focus();
        }

        private void btn_employeeDelete_Click(object sender, EventArgs e)
        {
            if (dgv_listEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgv_listEmployee.SelectedRows[0].Cells["Id"].Value is not int employeeId)
            {
                MessageBox.Show("Dữ liệu nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _employeeService.DeleteEmployee(employeeId);
                LoadData();
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
            }
        }

        private void btn_employeeFix_Click(object sender, EventArgs e)
        {
            if (dgv_listEmployee.SelectedRows.Count > 0)
            {
                int employeeId = (int)dgv_listEmployee.SelectedRows[0].Cells["Id"].Value;
                string employeeName = dgv_listEmployee.SelectedRows[0].Cells["Name"].Value.ToString();
                string phone = dgv_listEmployee.SelectedRows[0].Cells["Phone"].Value?.ToString();
                DateTime dateOfJoining = (DateTime)dgv_listEmployee.SelectedRows[0].Cells["DateOfJoining"].Value;

                txt_employeeName.Text = employeeName;
                txt_employeePhone.Text = phone;
                dateTimePicker_employees_manager_startDate.Value = dateOfJoining;

                btn_employeeUpdate.Tag = employeeId;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_employeeUpdate_Click(object sender, EventArgs e)
        {
            if (btn_employeeUpdate.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_employeeName.Text) || string.IsNullOrWhiteSpace(txt_employeePhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int employeeId = (int)btn_employeeUpdate.Tag;
            string employeeName = txt_employeeName.Text;
            string phone = txt_employeePhone.Text;
            DateTime dateOfJoining = dateTimePicker_employees_manager_startDate.Value;

            Employee employee = new Employee
            {
                Id = employeeId,
                Name = employeeName,
                Phone = phone,
                DateOfJoining = dateOfJoining
            };

            _employeeService.UpdateEmployee(employee);
            LoadData();
            MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo");

            txt_employeeName.Clear();
            txt_employeePhone.Clear();
            btn_employeeUpdate.Tag = null;
        }

        private void btn_employeeSearch_Click(object sender, EventArgs e)
        {
            string keyword = txt_employees_manager_search.Text.Trim().ToLower();
            var employees = _employeeService.GetAllEmployees()?.ToList() ?? new List<Employee>();

            var searchResult = string.IsNullOrEmpty(keyword)
                ? employees
                : employees.Where(e => e.Name.ToLower().Contains(keyword)).ToList();

            dgv_listEmployee.DataSource = null;
            dgv_listEmployee.DataSource = searchResult;
        }

        private void comboBox_listLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
