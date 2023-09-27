using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635069Assignment1.Controllers
{
    public class GreetingController : ApiController
    {

        /// <summary>
        /// This method returns the string "Hello World!" when receiving post request
        /// <example> POST api/Greeting </example>
        /// </summary>
        /// <returns>[ "Hello World!" ]</returns>


        public IEnumerable<string> POST()
        {
            return new string[] { "Hello World!" };
        }


        /// <summary>
        /// GET api/Greeting/3
        /// GET api/Greeting/6
        /// GET api/Greeting/0
        /// </summary>
        /// <param name="id">Returns the string "Greetings to {id} people!" where id is an integer</param>
        /// <returns>The input greetings</returns>

        public string Get(int id)
        {
            return  "Greetings to " + id + " people!";
        }
    }

}
