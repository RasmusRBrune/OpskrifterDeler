using OpskrifterDeler.Models;

namespace OpskrifterDeler.Interfaces
{
    public interface IFavoriteRepository : IEntityRepository<Favorite>
    {
        public Task<IEnumerable<Favorite>> GetAllByIdAsync();
        public Task<Favorite> DeleteById(int mealId, Guid id);
        public Task<Favorite> GetSingleByIdAsync(int mealId, Guid id);
    }
}
