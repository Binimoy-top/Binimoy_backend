using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using test111binimoy.JwtToken;
using test111binimoy.Models;

namespace test111binimoy.Controllers
{
    public class AccountController : ApiController
    {
        // this page is for only test case 


        private TestDbContext db = new TestDbContext();

        //[EnableCors(origins: "https://binimoy-top.github.io", headers: "*", methods: "*")]
     

        //[ResponseType(typeof(Users))]
        //public IHttpActionResult UserToken(Users inpUser)
        //{
        //    Users users = db.Users.Where(s => s.username.Equals(inpUser.username) && s.Password.Equals(inpUser.Password)).FirstOrDefault();
        //    if (users != null)
        //    {
        //        jwtWithusersInfo vvv = new jwtWithusersInfo();
        //        vvv.token = "asdasd";
        //        vvv.Users = users;
        //        return Ok(vvv);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}

        [HttpGet]
        public HttpResponseMessage ValidLogin(string username,string password)
        {

            var obj = db.Users.Where(s => s.username.Equals(username) && s.Password.Equals(password)).FirstOrDefault();
            if (obj != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK,value: tokenManager.GenerateToken(username)+"pain nau"+ obj.Password.ToString());
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadGateway, message: "wrong username and pass");
            }
        }
    }
}
