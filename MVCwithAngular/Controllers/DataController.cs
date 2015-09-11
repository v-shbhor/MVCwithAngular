using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MVCwithAngular.Controllers
{
    public class DataController : ApiController
    {
        public JsonResult GetLastContact()
        {
            Contact c = null;
            using(MyDataBaseEntities dc = new MyDataBaseEntities())
            {
                c = dc.Contacts.OrderBy(a => a.ContactID).Take(1).FirstOrDefault();
            }
            return new JsonResult { Data = c, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
