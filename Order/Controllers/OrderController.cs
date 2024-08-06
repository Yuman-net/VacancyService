using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Order.Controllers
{
    [Route("Orders")]
    public class OrderController : Controller
    {
        [Authorize]
        [HttpGet("order")]
        public string GetOrder()
        {
            return "String from Order Conroller";
        }
    }
}
