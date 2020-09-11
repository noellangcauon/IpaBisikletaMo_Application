using IpaBisikletaMo_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitOfWork
{
    public class GenericUnitOfWork
    {
        /// <summary>
        /// Set the entity
        /// </summary>
        /// <typeparam name="TEntityType"></typeparam>
        /// <returns></returns>

        private IBMEntities _dbContext = new IBMEntities();

        public GenericRepository<TEntityType> GetRepoInstance<TEntityType>() where TEntityType : class
        {
            return new GenericRepository<TEntityType>(_dbContext);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}