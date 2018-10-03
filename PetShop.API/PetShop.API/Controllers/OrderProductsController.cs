using System.Web.Http;
using PetShop.Business;
using PetShop.Model;

namespace PetShop.API.Controllers
{
    public class OrderProductsController : ApiController
    {

        // POST api/OrderProducts
        public bool Post([FromBody] Order order)
        {
            var orderService = new OrderService();
            return orderService.SaveData(order);
        }
    }
}