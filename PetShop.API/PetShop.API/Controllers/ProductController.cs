using System.Collections.Generic;
using System.Web.Http;
using PetShop.Business;
using PetShop.Model;

namespace PetShop.API.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            var productService = new ProductService();
            return productService.GetData();
        }

         

        // POST: api/Product
        public bool Post([FromBody]Product product)
        {
            var productService = new ProductService();
            return productService.AddProduct(product);
        }

        
    }
}
