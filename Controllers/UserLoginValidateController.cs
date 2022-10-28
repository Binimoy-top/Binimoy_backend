using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using test111binimoy.JwtToken;
using test111binimoy.Models;

namespace test111binimoy.Controllers
{
    public class UserLoginValidateController : ApiController
    {
        private TestDbContext db = new TestDbContext();

        [EnableCors(origins: "https://binimoy-top.github.io", headers: "*", methods: "*")]

        // POST: api/UserLoginValidate
        [ResponseType(typeof(Users))]
        public IHttpActionResult PostUsers(Users users)
        {
            Users matchedusers = db.Users.Where(s => (s.username.Equals(users.username) || s.email.Equals(users.email)) && s.Password.Equals(users.Password)).FirstOrDefault();
            if (matchedusers != null)
            {
                jwtWithusersInfo vvv = new jwtWithusersInfo();
                vvv.token = tokenManager.GenerateToken(matchedusers.username);
                vvv.Users = matchedusers;
                return Ok(vvv);
            }
            else
            {
                return NotFound();
            }
        }

 
      
    }
}