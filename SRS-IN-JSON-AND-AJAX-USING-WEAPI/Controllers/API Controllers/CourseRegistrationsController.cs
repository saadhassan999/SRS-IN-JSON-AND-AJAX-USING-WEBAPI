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
using SRS_IN_JSON_AND_AJAX_USING_WEAPI.Models;

namespace SRS_IN_JSON_AND_AJAX_USING_WEAPI.Controllers.API_Controllers
{
    public class CourseRegistrationsController : ApiController
    {
        private SRSdbEntities db = new SRSdbEntities();

        // GET: api/CourseRegistrations
        public IQueryable<CourseRegistration> GetCourseRegistrations()
        {
            return db.CourseRegistrations;
        }

        // GET: api/CourseRegistrations/5
        [ResponseType(typeof(CourseRegistration))]
        public IHttpActionResult GetCourseRegistration(int id)
        {
            CourseRegistration courseRegistration = db.CourseRegistrations.Find(id);
            if (courseRegistration == null)
            {
                return NotFound();
            }

            return Ok(courseRegistration);
        }

        // PUT: api/CourseRegistrations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCourseRegistration(int id, CourseRegistration courseRegistration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != courseRegistration.CourseRegistrationId)
            {
                return BadRequest();
            }

            db.Entry(courseRegistration).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseRegistrationExists(id))
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

        // POST: api/CourseRegistrations
        [ResponseType(typeof(CourseRegistration))]
        public IHttpActionResult PostCourseRegistration(CourseRegistration courseRegistration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CourseRegistrations.Add(courseRegistration);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = courseRegistration.CourseRegistrationId }, courseRegistration);
        }

        // DELETE: api/CourseRegistrations/5
        [ResponseType(typeof(CourseRegistration))]
        public IHttpActionResult DeleteCourseRegistration(int id)
        {
            CourseRegistration courseRegistration = db.CourseRegistrations.Find(id);
            if (courseRegistration == null)
            {
                return NotFound();
            }

            db.CourseRegistrations.Remove(courseRegistration);
            db.SaveChanges();

            return Ok(courseRegistration);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CourseRegistrationExists(int id)
        {
            return db.CourseRegistrations.Count(e => e.CourseRegistrationId == id) > 0;
        }
    }
}