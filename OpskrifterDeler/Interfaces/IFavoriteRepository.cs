using OpskrifterDeler.Models;

namespace OpskrifterDeler.Interfaces
{
    public interface IFavoriteRepository : IEntityRepository<Favorite>
    {
        Task<IEnumerable<Favorite>> GetAllByIdAsync();
        Task<Favorite> DeleteById(int mealId, Guid id);
    }
}
