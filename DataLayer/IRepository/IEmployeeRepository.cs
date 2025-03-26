using TransferObject.TransferObject;

namespace DataLayer.IRepository
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> GetAllEmployees();  // Sử dụng IEnumerable
        Employee GetEmployeeById(int id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        List<string> GetAllRoles();
    }
}
