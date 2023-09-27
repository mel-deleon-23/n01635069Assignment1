using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635069Assignment1.Controllers
{
    public class AddTenController : ApiController
    {

        /// <summary>
        /// GET api/AddTen/21 - > 31
        /// GET api/AddTen/0 - > 10
        /// GET api/AddTen/-9 - > 1
        /// </summary>
        /// <param name="id">The input number to add to</param>
        /// <returns>The input number plus 10</returns>

        public int Get(int id)
        {
            int result = id + 10;
            return result;
        }

    }
}
