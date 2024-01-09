using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;

namespace OpskrifterDeler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : BaseEntityController<Favorite, Guid>
    {
        protected readonly IFavoriteService _service;
        public FavoriteController(IFavoriteService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("getall/{id}")]
        public async Task<IActionResult> GetAllById(Guid id)
        {
            try
            {
                var result = await _service.GetAllByIdAsync();
                if (result == null)
                {
                    return Problem("Failed to load list");
                }
                else if (!result.Any())
                {
                    return NoContent();
                }
                result = result.Where(e => e.AccountId == id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
                
        [HttpGet("getsingle/{mealId}/{id}")]
        public async Task<IActionResult> GetSingleById(int mealId, Guid id)
        {
            try
            {
                var result = await _service.GetSingleByIdAsync(mealId, id);
                if (result == null)
                {
                    return Problem("Failed to load list");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpDelete("delete/{mealId}/{id}")]
        public async Task<IActionResult> DeleteById(int mealId, Guid id)
        {
            try
            {
                var result = await _service.DeleteById(mealId, id);
                if (result == null)
                {
                    return Problem("Failed to load list");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
