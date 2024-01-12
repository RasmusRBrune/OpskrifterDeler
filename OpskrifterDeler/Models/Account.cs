namespace OpskrifterDeler.Models
{
    public class Account : BaseEntity<Guid>
    {
        public Guid AccountId { get; set; }

        public ICollection<Favorite>? Favorite { get; set; }

        public ICollection<Review>? Reviews { get; set; }
    }
}
