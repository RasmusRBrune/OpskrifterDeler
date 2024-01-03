using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;

namespace OpskrifterDeler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : BaseEntityController<Favorite, Guid>
    {
        public FavoriteController(IFavoriteService service) : base(service)
        {
        }
    }
}
