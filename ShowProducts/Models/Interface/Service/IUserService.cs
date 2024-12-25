namespace ShowProducts.Models.Interface.Service
{
    public interface IUserService
    {
        void AddUser(User user);
        public User Login(string username, string password);
        public bool Register(User user);
    }
}
