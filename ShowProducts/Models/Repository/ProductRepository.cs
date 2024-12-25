using Microsoft.EntityFrameworkCore;
using ShowProducts.Models.Db;
using ShowProducts.Models.Interface.Repository;

namespace ShowProducts.Models.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductRepository()
        {
            _context = new ProductDbContext();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(string name)
        {
            var product = _context.Products.Find(name);
            if(product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            return _context.Products.Include(p => p.Category).ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
        }

        public void Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
