using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi_turismo.Models
{
    public class ApplicationSettings
    {
        public string JWT_Secret { get; set; }
        public string Cliente_URL { get; set; }
    }
}
