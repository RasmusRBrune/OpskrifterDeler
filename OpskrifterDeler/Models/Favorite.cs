namespace OpskrifterDeler.Models
{
    public class Favorite : BaseEntity<Guid>
    {
        public Guid AccountId { get; set; }
        
        public int MealId { get; set; }

        public Account? Account { get; set; }
    }
}
