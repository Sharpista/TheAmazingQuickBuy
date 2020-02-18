using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheAmazingQuickBuy.Domain.Interfaces.Repositories;
using TheAmazingQuickBuy.Repository.Context;

namespace TheAmazingQuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly QuickBuyContext QuickBuyContext;
        public BaseRepository(QuickBuyContext quickBuyContext)
        {
            QuickBuyContext = quickBuyContext;
        }
        public void Add(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Add(entity);
            QuickBuyContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
           return QuickBuyContext.Set<TEntity>().ToList();
        }

        public TEntity GetByIdint(int id)
        {
            return QuickBuyContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
           QuickBuyContext.Remove(entity);
            QuickBuyContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Update(entity);
            QuickBuyContext.SaveChanges();
        }
        public void Dispose()
        {
            QuickBuyContext.Dispose();
        }
    }
}
