using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;

namespace TestLog.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController:Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            throw new Exception();
        }
    }
}
