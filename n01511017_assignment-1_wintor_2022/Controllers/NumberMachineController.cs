using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01511017_assignment_1_wintor_2022.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// Question 5 Create a method which has an input {id}, and applies four mathematical operations to it.
        /// basic BODMAS operation on the given ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Get(int id)
        {
            return (id * id) / 2 + 10 - id;
        }
    }
}
