using Microsoft.IdentityModel.Tokens;
using ShowProducts.Models.Interface.Repository;
using ShowProducts.Models.Interface.Service;
using ShowProducts.Models.Repository;

namespace ShowProducts.Models.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository = new CategoryRepository();

        public void AddCategory(Category category)
        {
            _repository.Add(category);
        }

        public void DeleteCategory(int id)
        {
            _repository.Delete(id);
        }

        public List<Category> GetAllCategories()
        {
            return _repository.GetAll();
        }

        public void UpdateCategory(Category category)
        {
            _repository.Update(category);
        }
    }
}
