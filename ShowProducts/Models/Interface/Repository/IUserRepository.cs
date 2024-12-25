namespace ShowProducts.Models.Interface.Repository
{
    public interface IUserRepository
    {
        void Add(User user);
        public User GetByusername(string username);
    }
}
