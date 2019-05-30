using Loca.Shared.Entities;

namespace Loca.Domain.Entities
{
    public class Producer : Entity
    {
        public string Name { get; private set; }

        public Producer(string name)
        {
            Name = name;
        }
    }
}
