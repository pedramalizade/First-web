using Microsoft.EntityFrameworkCore;
using ShowProducts.Models.Db;
using ShowProducts.Models.Interface.Repository;

namespace ShowProducts.Models.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ProductDbContext _context;
        public UserRepository()
        {
            _context = new ProductDbContext();
        }
        public void Add(User user)
        {
            _context.Users.Add(user);   
            _context.SaveChanges();
        }

        public User GetByusername(string username)
        {
            var result = _context.Users.FirstOrDefault(u => u.UserName == username);
            return result;
        }
    }
}
