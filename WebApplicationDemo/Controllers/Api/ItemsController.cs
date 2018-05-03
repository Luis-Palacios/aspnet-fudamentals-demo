using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplicationDemo.Controllers.Api
{
    [RoutePrefix("api/items")]
    public class ItemsController: ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetItems()
        {
            return Ok(new { Foo = "var" });
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetItem(int id)
        {
            return Ok(new { Foo = id });
        }
    }
}