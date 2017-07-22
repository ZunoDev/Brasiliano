using Brasiliano.Data.Model;
using Brasiliano.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Brasiliano.Controllers
{
    public class EstadoController : ApiController
    {
        private EntityContext ctx = new EntityContext();

        public IEnumerable<Estado> Get()
        {
            return ctx.Estado.ToList();
        }

        public IHttpActionResult Get(int id)
        {
            Estado state = ctx.Estado.Find(id);
            if (state == null)
            {
                return NotFound();
            }

            return Ok(state);
        }

        public IHttpActionResult Post([FromBody]Estado state)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ctx.Estado.Add(state);
            ctx.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { controller = "Estado", id = state.ID }, state);
        }

        public IHttpActionResult Put(int id, Estado state)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            ctx.Entry(state).State = EntityState.Modified;
            ctx.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult Delete(int id)
        {
            Estado state = ctx.Estado.Find(id);
            if (state == null)
            {
                return NotFound();
            }

            ctx.Estado.Remove(state);
            ctx.SaveChanges();

            return Ok(state);
        }
    }
}
