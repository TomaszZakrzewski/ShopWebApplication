using Shop.Database;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Application.ProductAdmin
{
    public class DeleteProduct
    {
        private ShopAppDbContext _context;
        public DeleteProduct(ShopAppDbContext context)
        {
            _context = context;
        }
        public async Task Do(int id)
        {
            var Product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(Product);
            await _context.SaveChangesAsync();
        }
    }
}
