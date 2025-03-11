using TransferObject;
using System.Collections.Generic;

namespace DataLayer.IRepository
{
    public interface ITableRepository
    {
        IEnumerable<Table> GetTablesByStatus(TableStatus status); // Tìm bàn ăn theo trạng thái
        IEnumerable<Table> GetAllTables();  // Lấy danh sách tất cả bàn
        Table GetTableById(int id);  // Lấy thông tin bàn theo ID
        void AddTable(Table table);   // Thêm bàn mới
        void UpdateTable(Table table); // Cập nhật thông tin bàn
        void DeleteTable(int id);   // Xóa bàn
        void SaveChanges();
    }
}
