using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01511017_assignment_1_wintor_2022.Controllers
{
    /// <summary>
    /// simply return the given + 10 ( basic addition )
    /// </summary>
    public class AddTenController : ApiController
    {
        public int Get(int id)
            {
      return 10 + id;
            }
    }
}
