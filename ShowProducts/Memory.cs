using ShowProducts.Models;

namespace ShowProducts
{
    public static class Memory
    {
        public static List<Product> Products { get; set; }
        static Memory()
        {
            Products = new List<Product>()
            {
                new Product() { Id = 1,Name = "Ball", price = 1000, Qantity = 10},
                new Product() { Id = 2,Name = "Book", price = 500, Qantity = 5}
            };
        }
    }
}
