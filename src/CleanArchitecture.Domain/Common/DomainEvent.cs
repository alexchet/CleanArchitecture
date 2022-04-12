namespace CleanArchitecture.Domain.Common
{
    public interface IHasDomainEvent
    {
        public List<DomainEvent> DomainEvents { get; set; }
    }

    public abstract class DomainEvent
    {
        protected DomainEvent()
        {
            OccuredOn = DateTimeOffset.UtcNow;
        }
        public bool IsPublished { get; set; }
        public DateTimeOffset OccuredOn { get; protected set; } = DateTime.UtcNow;
    }
}
