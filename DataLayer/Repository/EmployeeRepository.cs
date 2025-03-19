using DataLayer.IRepository;
using System.Linq;
using TransferObject.TransferObject;

namespace DataLayer.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Employee> GetAllEmployees() => _context.Employees;

        public Employee GetEmployeeById(int id) => _context.Employees.FirstOrDefault(e => e.Id == id);

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

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
