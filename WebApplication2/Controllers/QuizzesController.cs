using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizzesController : ControllerBase
    {
        
        private readonly IQuizService _service;
        public QuizzesController(IQuizService service)
        {
            _service = service;
        }

        // GET: api/<QuizzesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<QuizzesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<QuizzesController>
        [HttpPost]
        public ActionResult PostQuiz([FromBody] Quiz quiz)
        {
            var quizInsertFlag = _service.CreateQuiz(quiz);
            if (quizInsertFlag)
            {
                return Ok(quiz);
            }
            else
            {
                return BadRequest(quiz);
            }
        }

        // PUT api/<QuizzesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuizzesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        
    }
}
