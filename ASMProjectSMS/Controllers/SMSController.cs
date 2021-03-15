using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nexmo.Api;


namespace ASMProjectSMS.Controllers
{
    public class SMSController : Controller
    {
        [System.Web.Mvc.HttpGet]
        public ActionResult Send()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Send(string to, string text)
        {
            var client = new Client(creds: new Nexmo.Api.Request.Credentials
            {
                ApiKey = "8c320b03",    
                ApiSecret = "WiVYqmFnHapIR69j"
            });
            var results = client.SMS.Send(request: new SMS.SMSRequest
            {
                from = "Verified code",
                to = to,
                text = text
            });

            return View();
        }
    }
}