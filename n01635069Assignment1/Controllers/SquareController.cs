using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635069Assignment1.Controllers
{
    public class SquareController : ApiController
    {

        /// <summary>
        /// GET api/Square/2 - > 4
        /// GET api/Square/-2 - > 4
        /// GET api/Square/10 - > 100
        /// </summary>
        /// <param name="id">The input number to square</param>
        /// <returns>The input number square</returns>

        public int Get(int id)
        {
            int result = id*id;
            return result;
        }

    }
}
