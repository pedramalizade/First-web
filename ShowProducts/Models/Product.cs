namespace ShowProducts.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
        public int Qantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        
    }
}
