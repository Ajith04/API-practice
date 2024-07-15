using API_Assignment.Database;
using API_Assignment.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _ProductService;

        public ProductController(ProductService productservice)
        {
            _ProductService = productservice;
        }
        [HttpPost ("add-item")]
        public Product addItem(Product product)
        {
            var data = _ProductService.addItem(product);
            return data;
        }

        [HttpGet ("get-all-items")]
        public List<Product> getAllItems()
        {
            var data = _ProductService.getAllItems();
            return data;
        }
        [HttpGet ("get-item-by-id/{id}")]
        public Product getItemById(Guid id)
        {
            var data = _ProductService.getItemById(id);
            return data;
        }
        [HttpPut ("edit")]
        public Product edit(Product product)
        {
            var data = _ProductService.edit(product);
            return data;
        }
        [HttpDelete ("remove-product/{id}")]
        public void removeProduct(Guid id)
        {
            _ProductService.removeProduct(id);
        }
    }
}
