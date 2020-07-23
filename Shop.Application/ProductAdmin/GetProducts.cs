using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.ProductAdmin
{
    public class GetProducts
    {
        private ShopAppDbContext _ctx;
        public GetProducts(ShopAppDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<ProductViewModel> Do()=>
            _ctx.Products.ToList().Select(x=> new ProductViewModel
            {
                Name = x.Name,
                Description= x.Description,
                Price=x.Price
            });
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    }
}

