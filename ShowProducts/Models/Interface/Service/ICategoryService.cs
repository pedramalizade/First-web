namespace ShowProducts.Models.Interface.Service
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        void AddCategory(Category category);    
        void UpdateCategory(Category category);
        void DeleteCategory(int id);

    }
}
