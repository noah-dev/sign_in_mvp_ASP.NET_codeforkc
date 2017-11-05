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
using SignInMP_00.Models;

namespace SignInMP_00.Controllers
{
    public class SignInsController : ApiController
    {
        private SignInDB db = new SignInDB();

        // GET: api/SignIns
        public IQueryable<SignIn> GetSignIns()
        {
            return db.SignIns;
        }

        // GET: api/SignIns/5
        [ResponseType(typeof(SignIn))]
        public IHttpActionResult GetSignIn(int id)
        {
            SignIn signIn = db.SignIns.Find(id);
            if (signIn == null)
            {
                return NotFound();
            }

            return Ok(signIn);
        }

        // PUT: api/SignIns/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSignIn(int id, SignIn signIn)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != signIn.Id)
            {
                return BadRequest();
            }

            db.Entry(signIn).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SignInExists(id))
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

        // POST: api/SignIns
        [ResponseType(typeof(SignIn))]
        public IHttpActionResult PostSignIn(SignIn signIn)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // Append unix time as of write. There is probably a way to replicat this behavior in model side,
            // so this will also be a candidate for refactoring.
            // https://stackoverflow.com/questions/17632584/how-to-get-the-unix-timestamp-in-c-sharp
            signIn.DateTimeUnix = (int)DateTimeOffset.Now.ToUnixTimeSeconds();
            db.SignIns.Add(signIn);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = signIn.Id }, signIn);
        }

        // DELETE: api/SignIns/5
        [ResponseType(typeof(SignIn))]
        public IHttpActionResult DeleteSignIn(int id)
        {
            SignIn signIn = db.SignIns.Find(id);
            if (signIn == null)
            {
                return NotFound();
            }

            db.SignIns.Remove(signIn);
            db.SaveChanges();

            return Ok(signIn);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SignInExists(int id)
        {
            return db.SignIns.Count(e => e.Id == id) > 0;
        }
    }
}