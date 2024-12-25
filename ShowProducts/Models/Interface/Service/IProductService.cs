namespace ShowProducts.Models.Interface.Service
{
    public interface IProductService
    {
        List<Product> GetAllProdct();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(string name);
    }
}
