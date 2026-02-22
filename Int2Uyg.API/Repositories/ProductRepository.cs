using Int2Uyg.API.Models;

namespace Int2Uyg.API.Repositories
{
    public class ProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> GetList()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Where(s => s.Id == id).FirstOrDefault();
        }

        public void Add(Product model)
        {
            _context.Products.Add(model);
            _context.SaveChanges(); 
        }

        public void Update(Product model)
        {
            var product = GetById(model.Id);
            if (product != null)
            {
                product.Name = model.Name;
                product.Price = model.Price;
                product.Description = model.Description;
                product.IsActive = model.IsActive;

                _context.Products.Update(product);
                _context.SaveChanges(); 
            }
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges(); 
            }
        }
    }
}