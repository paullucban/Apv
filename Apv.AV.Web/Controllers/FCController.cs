using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Apv.AV.Services.FC;

namespace Apv.AV.Web.Controllers
{

    [Route("api/[controller]")]
    public class FCController:Controller
    {
        private IApvFCServices _iApvService;

        public FCController(IApvFCServices iApvService)
        {
            _iApvService = iApvService;
        }

        // GET api/FC/Versions
        [HttpGet("/Versions")]
        public IActionResult getAllAppVersions()
        {
            return Ok(_iApvService.getAllAppVersions());   
        }

    }
}
