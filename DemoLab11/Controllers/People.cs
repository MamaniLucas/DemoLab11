using DemoLab11.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoLab11.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class People : ControllerBase
    {
        [HttpGet(Name = "Listar")]
        public List<Person> Get()
        {

            List<Person> list = new List<Person>();
            // Person.Join("&", list);
            return list;
        }



    }

}

