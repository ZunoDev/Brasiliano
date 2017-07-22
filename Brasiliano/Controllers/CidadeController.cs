using Brasiliano.Data.Model;
using Brasiliano.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Brasiliano.Controllers
{
    public class CidadeController : ApiController
    {
        private EntityContext ctx = new EntityContext();

        public IEnumerable<Cidade> Get()
        {
            return ctx.Cidade.ToList();
        }

        public IHttpActionResult Get(int id)
        {
            Cidade city = ctx.Cidade.Find(id);
            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }

        public IHttpActionResult Post([FromBody]Cidade city)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ctx.Cidade.Add(city);
            ctx.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { controller = "Cidade", id = city.ID }, city);
        }

        public IHttpActionResult Put(int id, Cidade city)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            ctx.Entry(city).State = EntityState.Modified;
            ctx.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult Delete(int id)
        {
            Cidade city = ctx.Cidade.Find(id);
            if (city == null)
            {
                return NotFound();
            }

            ctx.Cidade.Remove(city);
            ctx.SaveChanges();

            return Ok(city);
        }
    }
}
