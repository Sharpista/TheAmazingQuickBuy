using System;
using TheAmazingQuickBuy.Domain.Entities;
using System.Collections.Generic;
using System.Text;
using TheAmazingQuickBuy.Domain.Interfaces.Repositories;

namespace TheAmazingQuickBuy.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository()
        {

        }
    }
}
