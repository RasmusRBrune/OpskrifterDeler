using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;

namespace OpskrifterDeler.Services
{
    public class ReviewService : BaseEntityService<Review, Guid>
    {
        public ReviewService(IReviewRepository repository) : base(repository)
        {
        }
    }
}
