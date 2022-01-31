using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01511017_assignment_1_wintor_2022.Controllers
{
    public class GreetingController : ApiController
    {

        // Question 4 Returns the string “Greetings to {id} people!” where id is an integer value.

        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
