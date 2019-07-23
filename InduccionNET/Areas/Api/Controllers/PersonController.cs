using InduccionNET.Areas.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InduccionNET.Areas.Api.Controllers
{
    [RoutePrefix("v1.0/person")]
    public class PersonController : ApiController
    {

        [HttpGet]
        [Route("getPerson")]
        public HttpResponseMessage getPerson()
        {
            PersonApplicationService person = new PersonApplicationService();
            return Request.CreateResponse(HttpStatusCode.OK, person.GetPerson());
        }
    }
}
