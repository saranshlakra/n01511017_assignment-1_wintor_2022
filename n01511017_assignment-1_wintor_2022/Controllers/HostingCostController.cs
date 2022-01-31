using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01511017_assignment_1_wintor_2022.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// id is number of days, 
        /// it takes number of days and divide it by 14 because 1 FN is 14 + 1 because id show number of days elapsed after hosting has been purchased
        /// so my assumption is hosting is already purchased so 1 is implicit.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public double Get( int id)
        {
          
            int cost = (id / 14) + 1;
            double fortNightCost = (cost * 5.50);
            double tax = fortNightCost * 0.13;
            double total = tax + fortNightCost;
            return total;
        }
    }
}
