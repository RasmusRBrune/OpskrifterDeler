using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;

namespace OpskrifterDeler.Services
{
    public class FavoriteService : BaseEntityService<Favorite, Guid>, IFavoriteService
    {
        public FavoriteService(IFavoriteRepository repository):base(repository)
        {
                
        }
    }
}
