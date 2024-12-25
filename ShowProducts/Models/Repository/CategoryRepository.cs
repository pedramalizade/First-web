using Microsoft.EntityFrameworkCore;
using ShowProducts.Models.Db;
using ShowProducts.Models.Interface.Repository;

namespace ShowProducts.Models.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductDbContext _context;
        public CategoryRepository()
        {
            _context = new ProductDbContext();
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);            
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if(category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        public List<Category> GetAll()
        {
            return _context.Categories.Include(c => c.Products).ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Include(c => c.Products).FirstOrDefault(c => c.Id == id);
        }

        public void Update(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
