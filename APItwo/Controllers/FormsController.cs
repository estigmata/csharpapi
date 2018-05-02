using APItwo.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APItwo.Controllers
{
    public class FormsController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var result = from form in db.Forms
                             select new
                             {
                                 form.Id,
                                 form.Name,
                                 Field = from field in db.Fields
                                         where field.FormId == form.Id
                                         select new
                                         {
                                             field.Id,
                                             field.Name,
                                             field.TypeField
                                         }
                             };
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
