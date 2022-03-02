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
using familyGroup.Models;

namespace familyGroup.Controllers
{
    public class family_groupController : ApiController
    {
        private FamilyModel db = new FamilyModel();

        // GET: api/family_group
        public IQueryable<family_group> Getfamily_group()
        {
            return db.family_group;
        }

        // GET: api/family_group/5
        [ResponseType(typeof(family_group))]
        public IHttpActionResult Getfamily_group(int id)
        {
            family_group family_group = db.family_group.Find(id);
            if (family_group == null)
            {
                return NotFound();
            }

            return Ok(family_group);
        }

        // PUT: api/family_group/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putfamily_group(int id, family_group family_group)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != family_group.id)
            {
                return BadRequest();
            }

            db.Entry(family_group).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!family_groupExists(id))
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

        // POST: api/family_group
        [ResponseType(typeof(family_group))]
        public IHttpActionResult Postfamily_group(family_group family_group)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.family_group.Add(family_group);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (family_groupExists(family_group.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = family_group.id }, family_group);
        }

        // DELETE: api/family_group/5
        [ResponseType(typeof(family_group))]
        public IHttpActionResult Deletefamily_group(int id)
        {
            family_group family_group = db.family_group.Find(id);
            if (family_group == null)
            {
                return NotFound();
            }

            db.family_group.Remove(family_group);
            db.SaveChanges();

            return Ok(family_group);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool family_groupExists(int id)
        {
            return db.family_group.Count(e => e.id == id) > 0;
        }
    }
}