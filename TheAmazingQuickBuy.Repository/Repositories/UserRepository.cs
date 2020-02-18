using System;
using TheAmazingQuickBuy.Domain.Entities;
using System.Collections.Generic;
using System.Text;
using TheAmazingQuickBuy.Domain.Interfaces.Repositories;
using TheAmazingQuickBuy.Repository.Context;

namespace TheAmazingQuickBuy.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
               
        }
    }
}
