using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataAccess.Repositories.IRepositories
{
    public interface IRepositoryBase<TEntity>
         where TEntity : class
    {
        List<TEntity> GetAll();

        TEntity FindById(params object[] id);

        void InsertGraph(TEntity entity);

        void Update(TEntity entity);

        void Delete(params object[] id);

        void Delete(TEntity entity);

        void Insert(TEntity entity);
        
    }
}