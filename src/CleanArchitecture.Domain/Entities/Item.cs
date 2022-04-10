using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Domain.Entities
{
    public class Item : BaseEntity, IHasDomainEvent
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public PriorityLevel Priority { get; set; }
        private bool _done;
        public bool Done
        {
            get => _done;
            set
            {
                if (value == true && _done == false)
                {
                    //TODO When item completed event is done.
                    //DomainEvents.Add(new ItemCompletedEvent(this));
                }

                _done = value;
            }
        }


        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
    }
}
