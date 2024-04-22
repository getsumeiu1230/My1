using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class bookController : ControllerBase
    {
        // GET: api/book
        [HttpGet]
        public IEnumerable<book> Get()
        {
            return new book[]
            {
                new book() { Id = 1, Type = "文學", Name = "Jellyfish" ,Page = 335}
                ,new book(){Id = 2,Type = "宗教",Name = "金色沙漠",Page = 145}
            };
        }

        // GET: api/book/5
        [HttpGet("{bookname}", Name = "Get")]
        public book Get(string bookname)
        {
            if (bookname == "b0001")
            {
                return new book()
                {
                    Type = "文學",
                    Name="Jellyfish",
                    Page=335,
                };
            }


            return null;
        }

        // POST: api/book
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/book/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/book/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
