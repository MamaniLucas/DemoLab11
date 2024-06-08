using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoLab11.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public List<String> Get()
        {

            List<String> list = new List<String>();
            String.Join("&", list);
            return list;
        }

        [HttpGet(Name = "GetProducto")]
        public List<String> GetProduct50()
        {

            List<String> list = new List<String>();
            String.Join("&", list);
            return list;
        }
    }
}
