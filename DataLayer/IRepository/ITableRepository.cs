using System.Collections.Generic;
using TransferObject.TransferObject;

namespace DataLayer.IRepository
{
    public interface ITableRepository
    {
        IQueryable<Table> GetTablesByStatus(TableStatus status); // Tìm bàn ăn theo trạng thái
        IQueryable<Table> GetAllTables();  // Lấy danh sách tất cả bàn
        Table GetTableById(int id);  // Lấy thông tin bàn theo ID
        void AddTable(Table table);   // Thêm bàn mới
        void UpdateTable(Table table); // Cập nhật thông tin bàn
        void DeleteTable(int id);   // Xóa bàn
        void SaveChanges();
        void UpdateTableStatus(int tableId, TableStatus newStatus); // Cập nhật trạng thái bàn

        TableStatus GetTableStatus(int tableId); // Lấy trạng thái bàn
        void MarkTableAsEmpty(int tableId);
    }
}
