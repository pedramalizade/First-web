using ShowProducts.Models.Db;
using ShowProducts.Models.Interface.Repository;
using ShowProducts.Models.Interface.Service;
using ShowProducts.Models.Repository;
using System;

namespace ShowProducts.Models.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository = new UserRepository();
        private readonly ProductDbContext _appDbContext;
        public UserService()
        {
            _appDbContext = new ProductDbContext();
        }
        public void AddUser(User user)
        {
            _repository.Add(user);
        }

        public User Login(string username, string password)
        {
            var user = _repository.GetByusername(username);


            if (user != null)
            {
                if (user.Password == password)
                {
                    InMemoryDatabase.OnlineUser = user;
                    return user;

                }
                return null;
            }
            else
            {
                return null;
            }
        }

        public bool Register(User user)
        {
            var username = _appDbContext.Users.FirstOrDefault(t => t.UserName == user.UserName && t.Password == user.Password);
            if (username != null)
            {
                return false;
            }
            _appDbContext.Users.Add(user);
            InMemoryDatabase.OnlineUser = user;
            _appDbContext.SaveChanges();
            return true;
        }
    }
}
