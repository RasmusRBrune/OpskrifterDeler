using OpskrifterDeler.Models;

namespace OpskrifterDeler.Interfaces
{
    public interface IFavoriteService : IEntityService<Favorite,Guid>
    {
        public Task<IEnumerable<Favorite>> GetAllByIdAsync();
        public Task<Favorite> GetSingleByIdAsync(int mealId, Guid id);
        public Task<Favorite> DeleteById(int mealId, Guid id);
    }
}
