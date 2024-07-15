using API_Assignment.Database;
using API_Assignment.Services;

namespace API_Assignment.Repositories
{
    public class ProductRepo
    {
        private AppDbContext _dbContext;

        public ProductRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product addItem(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public List<Product> getAllItems()
        {
            var data = _dbContext.Products.ToList();
            return data;
        }

        public Product getItemById(Guid id)
        {
            var data = _dbContext.Products.SingleOrDefault(r => r.Id == id);
            return data;
        }

        public Product edit(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return product;
        }

        public void removeProduct(Product product)
        {
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }
        

    }
}
