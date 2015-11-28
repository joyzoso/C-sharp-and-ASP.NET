using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using EFWebAPI.Models;

namespace EFWebAPI.Controllers
{
    public class PenpalsController : ApiController
    {
        private EFWebAPIContext db = new EFWebAPIContext();

        // GET: api/Penpals
        public IQueryable<Penpal> GetPenpals()
        {
            return db.Penpals;
        }

        // GET: api/Penpals/5
        [ResponseType(typeof(Penpal))]
        public async Task<IHttpActionResult> GetPenpal(int id)
        {
            Penpal penpal = await db.Penpals.FindAsync(id);
            if (penpal == null)
            {
                return NotFound();
            }

            return Ok(penpal);
        }

        // PUT: api/Penpals/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPenpal(int id, Penpal penpal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != penpal.Id)
            {
                return BadRequest();
            }

            db.Entry(penpal).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PenpalExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Penpals
        [ResponseType(typeof(Penpal))]
        public async Task<IHttpActionResult> PostPenpal(Penpal penpal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Penpals.Add(penpal);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = penpal.Id }, penpal);
        }

        // DELETE: api/Penpals/5
        [ResponseType(typeof(Penpal))]
        public async Task<IHttpActionResult> DeletePenpal(int id)
        {
            Penpal penpal = await db.Penpals.FindAsync(id);
            if (penpal == null)
            {
                return NotFound();
            }

            db.Penpals.Remove(penpal);
            await db.SaveChangesAsync();

            return Ok(penpal);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PenpalExists(int id)
        {
            return db.Penpals.Count(e => e.Id == id) > 0;
        }
    }
}