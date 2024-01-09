using Microsoft.EntityFrameworkCore;
using OpskrifterDeler.Data;
using OpskrifterDeler.DBContext;
using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;
using System.Linq.Expressions;

namespace OpskrifterDeler.Repositories
{
    public class FavoriteRepository : BaseEntityRepository<Favorite>,IFavoriteRepository
    {
        protected readonly OpskrifterDelerContext _context;
        public FavoriteRepository(OpskrifterDelerContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Favorite> DeleteById(int mealId, Guid id)
        {
            try
            {
                var result = await _context.Favorites.FirstOrDefaultAsync(e => e.MealId == mealId && e.AccountId == id);
                if (result != null)
                {
                    _context.Favorites.Remove(result);
                    await _context.SaveChangesAsync();
                    return result;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public override Task<IEnumerable<Favorite>> GetAllWithIncludeAsync(Expression<Func<Favorite, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public override Task<Favorite> GetSingleWithIncludeAsync(Expression<Func<Favorite, bool>> expression)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Favorite>> IFavoriteRepository.GetAllByIdAsync()
        {
            try
            {
                return await QueryAll().ToListAsync();

            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<Favorite> GetSingleByIdAsync(int mealId, Guid id)
        {
            try
            {
                var result = await _context.Favorites.FirstOrDefaultAsync(e => e.MealId == mealId && e.AccountId == id);
                if (result != null)
                {
                    return result;
                }
                return null;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
