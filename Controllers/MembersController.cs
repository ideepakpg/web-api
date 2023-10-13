using Microsoft.AspNetCore.Mvc;
using web_api.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private AppDbContext context;

        public MembersController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<MembersController>
        [HttpGet]
        public IEnumerable<Member> Get()
        {
            return context.Members.ToList();
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public Member Get(int id)
        {
            return context.Members.Find(id);
        }

        // POST api/<MembersController>
        [HttpPost]
        public void Post([FromBody] Member member)
        {
            context.Members.Add(member);
            context.SaveChanges();
        }

        // PUT api/<MembersController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Member member)
        {
            context.Members.Update(member);
            context.SaveChanges();
        }

        // DELETE api/<MembersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var member = context.Members.Find(id);
            context.Members.Remove(member);
            context.SaveChanges();
        }
    }
}
