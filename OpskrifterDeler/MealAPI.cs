using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Text.Json;
using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;
using System.Security.Principal;

namespace OpskrifterDeler
{
    public partial class MealAPI
    {
        private readonly HttpClient client = new();

        public JsonSerializerOptions SerializerOptions { get; set; } = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            ReferenceHandler = ReferenceHandler.Preserve
        };

        public MealAPI()
        {
            client.BaseAddress = new Uri("https://localhost:44384/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<Favorite>> GetAllFavorite(string id)
        {
            var response = await client.GetAsync($"Favorite/getall/{id}").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadAsStringAsync();
                if (res != "")
                {
                    List<Favorite> t = JsonSerializer.Deserialize<List<Favorite>>(res, SerializerOptions);
                    return t;
                }
            }
            return new List<Favorite>();
        }

        public async Task<bool> DeleteFavoriteById(int mealId, Guid id)
        {
            var result = await client.DeleteAsync($"Favorite/delete/{mealId}/{id}").ConfigureAwait(false);
            if(result.IsSuccessStatusCode) { return true; }
            return false;
        }
    }
}