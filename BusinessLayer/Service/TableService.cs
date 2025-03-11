using DataLayer.IRepository;
using TransferObject;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Service
{
    public class TableService
    {
        private readonly ITableRepository _tableRepository;

        public TableService(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public IEnumerable<Table> GetAllTables()
        {
            return _tableRepository.GetAllTables();
        }

        public Table GetTableById(int id)
        {
            return _tableRepository.GetTableById(id);
        }

        public IEnumerable<Table> GetTablesByStatus(TableStatus status)
        {
            return _tableRepository.GetTablesByStatus(status);
        }

        public void AddTable(Table table)
        {
            _tableRepository.AddTable(table);
            _tableRepository.SaveChanges();
        }

        public void UpdateTable(Table table)
        {
            _tableRepository.UpdateTable(table);
            _tableRepository.SaveChanges(); // 🔹 Đảm bảo thay đổi được lưu

        }

        public void DeleteTable(int id)
        {
            _tableRepository.DeleteTable(id);
            _tableRepository.SaveChanges(); // 🔹 Đảm bảo thay đổi được lưu

        }
       

    }
}
