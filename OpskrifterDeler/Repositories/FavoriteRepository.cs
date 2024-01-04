using OpskrifterDeler.Data;
using OpskrifterDeler.DBContext;
using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;
using System.Linq.Expressions;

namespace OpskrifterDeler.Repositories
{
    public class FavoriteRepository : BaseEntityRepository<Favorite>,IFavoriteRepository
    {
        public FavoriteRepository(OpskrifterDelerContext context) : base(context)
        {
        }

        public override Task<IEnumerable<Favorite>> GetAllWithIncludeAsync(Expression<Func<Favorite, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public override Task<Favorite> GetSingleWithIncludeAsync(Expression<Func<Favorite, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
