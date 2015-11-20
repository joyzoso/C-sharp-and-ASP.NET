using MyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {ID = 1, Name = "Pinot Noir", Category = "Drinks", Price = 18.99 },
            new Product {ID = 2, Name = "Cheese", Category = "Food", Price = 3 },
            new Product {ID = 3, Name = "Red Dress", Category = "Clothing", Price = 54.99 }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.ID == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
