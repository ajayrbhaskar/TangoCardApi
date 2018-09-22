using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TangoApiSolution.Models;
using TangoCard.Raas.Models;

namespace TangoApiSolution.Controllers
{
    [Produces("application/json")]
    [Route("api/Status")]
    public class StatusController : Controller
    {
        [Route("GetSystemStatus")]
        [HttpGet]
        public async Task<IActionResult> GetSystemStatus()
        {
            try
            {
                var client = TangoConfiguration.Configuration();
                TangoCard.Raas.Controllers.StatusController status = client.Status;
                SystemStatusResponseModel result = await status.GetSystemStatusAsync();
                return Json(result);
            }
            catch (TangoCard.Raas.Exceptions.APIException ex)
            {
                var data = new { Status = false, ex };
                return Json(data);
            }


        }
    }
}