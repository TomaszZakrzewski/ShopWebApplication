﻿using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductAdmin;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.UI.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private ShopAppDbContext _ctx;
        public AdminController(ShopAppDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("products")]
        public IActionResult GetProducts() => Ok(new GetProducts(_ctx).Do());
        [HttpGet("products/{id}")]
        public IActionResult GetProduct(int id) => Ok(new GetProduct(_ctx).Do(id));
        [HttpPost("products")]
        public IActionResult CreateProduct([FromBody]CreateProduct.ProductViewModel vm) => Ok(new CreateProduct(_ctx).Do(vm));
        [HttpDelete("products/{id}")]
        public IActionResult DeleteProduct(int id) => Ok(new DeleteProduct(_ctx).Do(id));
        [HttpPut("products")]
        public IActionResult UpdateProduct([FromBody] UpdateProduct.ProductViewModel vm) => Ok(new UpdateProduct(_ctx).Do(vm));
    }
}
