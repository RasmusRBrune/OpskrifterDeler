using OpskrifterDeler.Interfaces;

namespace OpskrifterDeler.Models
{
    public abstract class BaseEntity<TId> : IEntity<TId>
    {
        public TId Id { get; set; }
        object IEntity.Id
        {
            get { return this.Id; }
            set { this.Id = (TId)value; }
        }

    }
}
