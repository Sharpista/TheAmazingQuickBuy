using System;
using System.Collections.Generic;

namespace TheAmazingQuickBuy.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity>: IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetByIdint(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);

    }
}
