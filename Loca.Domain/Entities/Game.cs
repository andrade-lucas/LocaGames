using Loca.Shared.Entities;

namespace Loca.Domain.Entities
{
    public class Game: Entity
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Producer Producer { get; private set; }
        public int Quantity { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }

        public Game(string name, double price, Producer producer, int quantity, string description, string image)
        {
            Name = name;
            Price = price;
            Producer = producer;
            Quantity = quantity;
            Description = description;
            Image = image;
        }
    }
}
