using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using _2015147386_ENT.Entities;
using _2015147386_PER;

namespace _2015147386_API.Controllers
{
    public class LugarViajesAPIController : ApiController
    {
        private TransporteDbContext db = new TransporteDbContext();

        // GET: api/LugarViajesAPI
        public IQueryable<LugarViaje> GetLugarViajes()
        {
            return db.LugarViajes;
        }

        // GET: api/LugarViajesAPI/5
        [ResponseType(typeof(LugarViaje))]
        public IHttpActionResult GetLugarViaje(int id)
        {
            LugarViaje lugarViaje = db.LugarViajes.Find(id);
            if (lugarViaje == null)
            {
                return NotFound();
            }

            return Ok(lugarViaje);
        }

        // PUT: api/LugarViajesAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLugarViaje(int id, LugarViaje lugarViaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lugarViaje.LugarViajeId)
            {
                return BadRequest();
            }

            db.Entry(lugarViaje).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LugarViajeExists(id))
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

        // POST: api/LugarViajesAPI
        [ResponseType(typeof(LugarViaje))]
        public IHttpActionResult PostLugarViaje(LugarViaje lugarViaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LugarViajes.Add(lugarViaje);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = lugarViaje.LugarViajeId }, lugarViaje);
        }

        // DELETE: api/LugarViajesAPI/5
        [ResponseType(typeof(LugarViaje))]
        public IHttpActionResult DeleteLugarViaje(int id)
        {
            LugarViaje lugarViaje = db.LugarViajes.Find(id);
            if (lugarViaje == null)
            {
                return NotFound();
            }

            db.LugarViajes.Remove(lugarViaje);
            db.SaveChanges();

            return Ok(lugarViaje);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LugarViajeExists(int id)
        {
            return db.LugarViajes.Count(e => e.LugarViajeId == id) > 0;
        }
    }
}