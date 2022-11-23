using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private static List<Person> person = new List<Person>{
            new Person()
        };


        [HttpGet("GetAll")]
        public ActionResult<List<Person>> Get(){
            return Ok(person);
        }

        [HttpGet("{id}")]
        public ActionResult<List<Person>> GetSingle(int id){
            return Ok(person.FirstOrDefault(p => p.Id == id));
        }


        [HttpPost]
        public ActionResult<List<Person>> AddPerson(Person newPerson){
            person.Add(newPerson);
            return Ok(person);
        }
    }
}