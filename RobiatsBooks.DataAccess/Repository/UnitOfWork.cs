using RobiatsBooks.DataAccess.Repository.IRepository;
using RobiatsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobiatsBooks.DataAccess.Repository
{
   public class UnitOfWork :IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }


        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()   //all the changes will be saved when the save changes method is called at the "parent" level-
        {
            _db.SaveChanges();
        }
    }
}
