using Bibliogame.Model.Entities.Enums;

namespace Bibliogame.Model.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product()
        {
        }

        public Product(string name, double price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
