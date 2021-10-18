using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace check_health.Controllers
{
    public class Response
    {
        public bool Executed { get; set; }
        public string ErrorMessage { get; set; }
        public Exception Exception { get; set; }
    }
}
