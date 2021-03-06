﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TangoCard.Raas.Controllers;
using TangoCard.Raas.Exceptions;
using TangoCard.Raas.Models;

namespace TangoApiSolution.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            TangoCard.Raas.Configuration.PlatformName = "QAPlatform2";
            TangoCard.Raas.Configuration.PlatformKey = "apYPfT6HNONpDRUj3CLGWYt7gvIHONpDRUYPfT6Hj";
            TangoCard.Raas.RaasClient client = new TangoCard.Raas.RaasClient();
            CatalogController catalog = client.Catalog;
            CatalogModel result = catalog.GetCatalogAsync().Result;
            return Json(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
