using FluentValidator;
using System;

namespace Loca.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        public Guid ID { get; private set; }

        public Entity()
        {
            ID = Guid.NewGuid();
        }
    }
}
