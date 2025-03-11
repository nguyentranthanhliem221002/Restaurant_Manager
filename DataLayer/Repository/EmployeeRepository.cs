using DataLayer.IRepository;
using TransferObject;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Lấy danh sách nhân viên (IEnumerable giúp tối ưu hiệu suất)
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.AsEnumerable();
        }

        // Lấy nhân viên theo ID
        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        // Thêm nhân viên mới
        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        // Cập nhật nhân viên
        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = _context.Employees.Find(employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Phone = employee.Phone;
                existingEmployee.DateOfJoining = employee.DateOfJoining;

                _context.SaveChanges();
            }
        }

        // Xóa nhân viên
        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}
