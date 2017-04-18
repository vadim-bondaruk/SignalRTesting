using Microsoft.AspNet.SignalR;
using SignalRTests.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRTests.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index(string message)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<MyHub>();
            context.Clients.All.hello(message);
      
                return View(); 
           

           
        }

        [HttpGet]
        public void SendEmail(string message, string id)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<MyHub>();
            context.Clients.Client(id).hello(message+" "+"C#");
            
        }
    }
}