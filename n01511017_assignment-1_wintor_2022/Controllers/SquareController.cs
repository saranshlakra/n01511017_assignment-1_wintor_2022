using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01511017_assignment_1_wintor_2022.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// to calculate square I multiplied id * id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Get(int id)
        {
            return (id * id);
        }
    }
}
