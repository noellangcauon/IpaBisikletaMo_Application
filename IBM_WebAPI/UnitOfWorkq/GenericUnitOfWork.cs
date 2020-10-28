using IBM_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace UnitOfWorkq
{
    public class GenericUnitOfWork
    {
        /// <summary>
        /// Set the entity
        /// </summary>
        /// <typeparam name="TEntityType"></typeparam>
        /// <returns></returns>

        private IBM _dbContext = new IBM();

        public GenericRepository<TEntityType> GetRepoInstance<TEntityType>() where TEntityType : class
        {
            return new GenericRepository<TEntityType>(_dbContext);
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}