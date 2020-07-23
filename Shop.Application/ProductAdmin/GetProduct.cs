using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.ProductAdmin
{
    public class GetProduct
    {
        private ShopAppDbContext _ctx;
        public GetProduct(ShopAppDbContext ctx)
        {
            _ctx = ctx;
        }
        public ProductViewModel Do(int id) =>
            _ctx.Products.Where(x=>x.Id==id).Select(x => new ProductViewModel
            {
                Name = x.Name,
                Description = x.Description,
                Price = x.Price
            })
            .FirstOrDefault();
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
    }
}
