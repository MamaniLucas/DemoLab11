using DemoLab11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoLab11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private static List<Person> people = new List<Person>();

        static PersonController()
        {
            // Pre-fill with 100 sample people
            for (int i = 1; i <= 100; i++)
            {
                people.Add(new Person
                {
                    Id = i,
                    Name = $"Person {i}",
                    Description = $"Description for Person {i}",
                    Age = 0
                });
            }
        }

        // GET: api/people
        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetPeople()
        {
            return Ok(people);
        }

        // GET: api/people/{id}
        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            var person = people.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        // POST: api/people
        [HttpPost]
        public ActionResult<Person> AddPerson([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest();
            }

            // Assign a new ID
            person.Id = people.Count > 0 ? people.Max(p => p.Id) + 1 : 1;
            people.Add(person);

            return CreatedAtAction(nameof(GetPersonById), new { id = person.Id }, person);
        }
    }

}
       

