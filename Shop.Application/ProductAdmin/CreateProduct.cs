using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shop.Database;
using Shop.Domain.Models;

namespace Shop.Application.ProductAdmin
{
    public class CreateProduct
    {
        private ShopAppDbContext _context;
        public CreateProduct(ShopAppDbContext context)
        {
            _context = context;
        }
        public async Task Do(ProductViewModel vm)
        {
            _context.Products.Add(new Product
            {
                Price = vm.Price,
                Name = vm.Name,
                Description = vm.Description
            });

            await _context.SaveChangesAsync();
        }
        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
    }
    
}
