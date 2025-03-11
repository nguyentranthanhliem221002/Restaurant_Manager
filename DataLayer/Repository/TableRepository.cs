using DataLayer.IRepository;
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

        // Lấy danh sách tất cả bàn
        public IEnumerable<Table> GetAllTables()
        {
            return _context.Tables.ToList();
        }

        // Lấy thông tin bàn theo ID
        public Table GetTableById(int id)
        {
            return _context.Tables.FirstOrDefault(t => t.Id == id);
        }

        // Tìm bàn ăn theo trạng thái
        public IEnumerable<Table> GetTablesByStatus(TableStatus status)
        {
            return _context.Tables.Where(t => t.Status == status).ToList();
        }

        // Thêm bàn mới
        public void AddTable(Table table)
        {
            _context.Tables.Add(table);
            _context.SaveChanges();
        }

        // Cập nhật thông tin bàn
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

        // Xóa bàn
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
            _context.SaveChanges(); // 🔹 Lưu tất cả thay đổi vào DB
        }


    }
}
