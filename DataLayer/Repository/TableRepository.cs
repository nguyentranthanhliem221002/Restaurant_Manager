using DataLayer.IRepository;
using System.Linq;
using TransferObject.TransferObject;

namespace DataLayer.Repository
{
    public class TableRepository : ITableRepository
    {
        private readonly ApplicationDbContext _context;

        public TableRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Table> GetAllTables() => _context.Tables;

        public Table GetTableById(int id) => _context.Tables.FirstOrDefault(t => t.Id == id);

        public IQueryable<Table> GetTablesByStatus(TableStatus status) => _context.Tables.Where(t => t.Status == status);

        public void AddTable(Table table)
        {
            _context.Tables.Add(table);
            _context.SaveChanges();
        }

        public void UpdateTable(Table table)
        {
            var existingTable = _context.Tables.Find(table.Id);
            if (existingTable != null)
            {
                existingTable.Name = table.Name;
                existingTable.Status = table.Status;
                _context.SaveChanges();
            }
        }

        public void DeleteTable(int id)
        {
            var table = _context.Tables.Find(id);
            if (table != null)
            {
                _context.Tables.Remove(table);
                _context.SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges(); // Lưu tất cả thay đổi vào DB
        }
        public void UpdateTableStatus(int tableId, TableStatus newStatus)
        {
            var table = _context.Tables.Find(tableId);
            if (table != null)
            {
                table.Status = newStatus;
                _context.SaveChanges();
            }
        }
        public TableStatus GetTableStatus(int tableId)
        {
            var table = _context.Tables.Find(tableId);
            return table != null ? table.Status : TableStatus.Available; // Trả về trạng thái mặc định nếu không tìm thấy
        }
        public void MarkTableAsEmpty(int tableId)
        {
            var table = _context.Tables.Find(tableId);
            if (table != null)
            {
                table.Status = TableStatus.Available; // Đánh dấu bàn là trống
                _context.SaveChanges(); // Lưu thay đổi vào database
            }
        }
    }
}
