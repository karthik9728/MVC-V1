using BulkuBook.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkuBook.DataAccess.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category{ get; }

        ICoverTypeRepository CoverType{ get; }

        void Save();
    }
}
