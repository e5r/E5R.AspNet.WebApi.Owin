using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace E5R.AspNet.WebApi.Owin
{
    [RoutePrefix("test")]
    public class TestController : ApiController
    {
        [Route, HttpGet]
        public IHttpActionResult Teste()
        {
            return Ok("E5R.AspNet.WebApi.Owin test!");
        }

        [Route("{message}"), HttpGet]
        public IHttpActionResult Test(string message)
        {
            return Ok(string.Format("E5R.AspNet.WebApi.Owin test! message [{0}]", message));
        }
    }
}