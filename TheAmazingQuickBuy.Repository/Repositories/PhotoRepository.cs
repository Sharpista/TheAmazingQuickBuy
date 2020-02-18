using TheAmazingQuickBuy.Domain.Entities;
using TheAmazingQuickBuy.Domain.Interfaces.Repositories;
using TheAmazingQuickBuy.Repository.Context;

namespace TheAmazingQuickBuy.Repository.Repositories
{
    public class PhotoRepository : BaseRepository<Photo>, IPhotoRepository
    {
        public PhotoRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {

        }
    }
}
