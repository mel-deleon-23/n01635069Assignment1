using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635069Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// GET api/NumberMachine/10 
        /// GET api/NumberMachine/-5 
        /// GET api/NumberMachine/30 
        /// </summary>
        /// <returns>The next four integers after the input</returns>


        public IEnumerable<int> Get(int id)
        {
            return new int[] { id+10, id-10, id*10, id/10 };

        }

    }

}