using System.Collections.Generic;
using TransferObject.TransferObject;

namespace DataLayer.IRepository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();  // Lấy tất cả khách hàng
        Customer GetCustomerById(int id);  // Lấy khách hàng theo ID
        void AddCustomer(Customer customer);   // Thêm khách hàng mới
        void UpdateCustomer(Customer customer); // Cập nhật khách hàng
        void DeleteCustomer(int id);   // Xóa khách hàng
    }
}
