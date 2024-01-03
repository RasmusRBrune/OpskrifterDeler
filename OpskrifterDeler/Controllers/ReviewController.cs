using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;

namespace OpskrifterDeler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : BaseEntityController<Review,Guid>
    {
        public ReviewController(IReviewService service) : base(service)
        {
        }
    }
}
