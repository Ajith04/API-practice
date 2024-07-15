using API_Assignment.Database;
using API_Assignment.Repositories;

namespace API_Assignment.Services
{
    public class ProductService
    {
        private ProductRepo _productrepo;

        public ProductService(ProductRepo productrepo)
        {
            _productrepo = productrepo;
        }

        public Product addItem(Product product)
        {
            var data = _productrepo.addItem(product);
            return data;
        }

        public List<Product> getAllItems()
        {
            var data = _productrepo.getAllItems();
            return data;
        }

        public Product getItemById(Guid id)
        {
            var data = _productrepo.getItemById(id);
            return data;
        }

        public Product edit(Product product)
        {
            var data = _productrepo.edit(product);
            return data;
        }

        public void removeProduct(Guid id)
        {
            var data = _productrepo.getItemById(id);
            _productrepo.removeProduct(data);
        }
    }
}
