using ShowProducts.Models.Interface.Repository;
using ShowProducts.Models.Interface.Service;
using ShowProducts.Models.Repository;

namespace ShowProducts.Models.Service
{
    public class ProdctService : IProductService
    {
        private readonly IProductRepository _repository = new ProductRepository();

        public void AddProduct(Product product)
        {
            _repository.Add(product);
        }

        public void DeleteProduct(string name)
        {
            _repository.Delete(name);
        }

        public List<Product> GetAllProdct()
        {
            return _repository.GetAll();
        }

        public void UpdateProduct(Product product)
        {
            _repository.Update(product);
        }
    }
}
