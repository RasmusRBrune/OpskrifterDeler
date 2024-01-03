namespace OpskrifterDeler.Models
{
    public class Review : BaseEntity<Guid>
    {
        public Guid AccountId { get; set; }

        public int StarValue { get; set; }

        public int MealId { get; set; }
    }
}
