using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01511017_assignment_1_wintor_2022.Controllers
{
    public class GreetingsController : ApiController
    {
        public string Get()
        {
            return "Hello World!";
        }
    }
}
