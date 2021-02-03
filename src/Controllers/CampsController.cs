using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Controllers
{
    public class CampsController : ControllerBase //CampsController derive from ControllerBase (base class - specialized in APIs)
    {
        [Route("api/[controller]")]
        public object Get()
        {
            return new { Moniker = "ATL2021", Name = "Atlanta Code Camp" };
        }
    }
}
