namespace OpskrifterDeler.Models
{
    public class Favorite : BaseEntity<Guid>
    {
        //fk
        public Guid AccountId { get; set; }
        
        public int MealId { get; set; }

        public Account? Account { get; set; }
    }
}
