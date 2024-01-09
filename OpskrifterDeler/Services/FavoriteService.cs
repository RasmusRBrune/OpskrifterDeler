using OpskrifterDeler.Data;
using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;

namespace OpskrifterDeler.Services
{
    public class FavoriteService : BaseEntityService<Favorite, Guid>, IFavoriteService
    {
        protected readonly IFavoriteRepository _repository;
        public FavoriteService(IFavoriteRepository repository):base(repository)
        {
            _repository = repository;

        }

        public async Task<Favorite> DeleteById(int mealId, Guid id)
        {
            var result = await _repository.DeleteById(mealId, id);
            return result;
        }

        public async Task<IEnumerable<Favorite>> GetAllByIdAsync()
        {
            var result = await _repository.GetAllByIdAsync();
            return result;
        } 
        
        public async Task<Favorite> GetSingleByIdAsync(int mealId, Guid id)
        {
            var result = await _repository.GetSingleByIdAsync(mealId, id);
            return result;
        }

    }
}
