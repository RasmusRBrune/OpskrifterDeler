namespace OpskrifterDeler.Models
{
    public class Favorite : BaseEntity<Guid>
    {
        public Guid AccounId { get; set; }
        
        public int MealId { get; set; }
    }
}
