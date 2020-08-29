using GeniusAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GeniusAPI.Controllers
{
    public class ProductController : ApiController
    {
        

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

       Product[] products = new Product[]
       {
            new Product { Id = 1, Name = "Microsoft", Category = "Technology Company", Price = 1 },
            new Product { Id = 2, Name = "Google", Category = "Internet Services", Price = 3.75M },
            new Product { Id = 3, Name = "Amazon", Category = "Online Retailer", Price = 16.99M },
            new Product { Id = 3, Name = "FaceBook", Category = "Social Media", Price = 16.99M },
            new Product { Id = 1, Name = "Apple",Category = "Electronics", Price = 1 },
            new Product { Id = 2, Name = "Intel", Category = "SemiConductors", Price = 3.75M },
            new Product { Id = 3, Name = "Uber", Category = "Transport", Price = 16.99M },
            new Product { Id = 3, Name = "Walmart", Category = "Retail", Price = 16.99M }
       };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
