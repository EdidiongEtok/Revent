namespace WebApplication4
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
    }
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new List<Product>
            {
                new Product { ProductId = 1, Description = "Product1" },
                new Product { ProductId = 1, Description = "Product1"}
            };

        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}
