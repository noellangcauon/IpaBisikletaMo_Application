using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitOfWork
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Get(int entity);

        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}