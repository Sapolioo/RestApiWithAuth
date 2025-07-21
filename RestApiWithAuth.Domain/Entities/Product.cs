namespace RestApiWithAuth.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Category { get; private set; }

        public Product(string name, decimal price, string category)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            Category = category;
        }

        public void Update(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
