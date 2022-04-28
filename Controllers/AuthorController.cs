
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using elsBlog.Context;
using elsBlog.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace elsBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private AuthorContext _authorContext;

        public AuthorController(AuthorContext authorContext)
        {
            _authorContext = authorContext;
        }

        // GET: api/<AuthorController>
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return _authorContext.Authors;
        }

        // GET api/<AuthorController>/5
        [HttpGet("{id}")]
        public Author Get(int id)
        {
            return _authorContext.Authors.FirstOrDefault(s => s.authorID == id);

        }

        // POST api/<AuthorController>
        [HttpPost]
        public string Post([FromBody] Author value)
        {
            _authorContext.Authors.Add(value);
            _authorContext.SaveChanges();
            return "Added successfully!!";
        }

        // PUT api/<AuthorController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Author value)
        {
            var author_id = _authorContext.Authors.FirstOrDefault(s => s.authorID == id);
            if (author_id != null)
            {
                _authorContext.Entry<Author>(author_id).CurrentValues.SetValues(value);
                _authorContext.SaveChanges();

            }
            return "Updated Successfully";
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            var author_id = _authorContext.Authors.FirstOrDefault(s => s.authorID == id);
            if (author_id != null)
            {
                _authorContext.Authors.Remove(author_id);
                _authorContext.SaveChanges();
            }
            return "Deleted Successfully";

        }


    }
}
