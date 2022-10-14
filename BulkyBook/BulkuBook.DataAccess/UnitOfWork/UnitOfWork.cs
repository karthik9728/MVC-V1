using BulkuBook.DataAccess.Repository;
using BulkuBook.DataAccess.Repository.IRepository;
using BulkuBook.DataAccess.UnitOfWork.Interface;
using BulkyBook.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkuBook.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }

        public UnitOfWork(ApplicationDbContext db) 
        { 
            _db = db;
            Category = new CategoryRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
