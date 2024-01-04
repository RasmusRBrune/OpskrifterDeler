using OpskrifterDeler.Data;
using OpskrifterDeler.DBContext;
using OpskrifterDeler.Models;
using System.Linq.Expressions;

namespace OpskrifterDeler.Repositories
{
    public class ReviewRepository : BaseEntityRepository<Review>
    {
        public ReviewRepository(OpskrifterDelerContext context) : base(context)
        {
        }
        public override Task<IEnumerable<Review>> GetAllWithIncludeAsync(Expression<Func<Review, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public override Task<Review> GetSingleWithIncludeAsync(Expression<Func<Review, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
