using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Apv.AV.Services.FC;

namespace Apv.AV.Web.Controllers
{
    
    public class FCController:Controller
    {
        private IApvFCServices _iApvService;

        public FCController(IApvFCServices iApvService)
        {
            _iApvService = iApvService;
        }

        // GET api/FC/Versions
        /// <summary>
        /// Gets all app versions.
        /// </summary>
        /// <returns>The all app versions.</returns>
        [HttpGet("api/[controller]/versions")]
        public IActionResult getAllAppVersions()
        {
            return Ok(_iApvService.getAllAppVersions());   
        }

        /// <summary>
        /// Gets the app version.
        /// </summary>
        /// <returns>The app version.</returns>
        /// <param name="platform">Platform.</param>
        [HttpGet("api/[controller]/versions/{platform}")]
        public IActionResult getAppVersion(string platform)
        {
            return Ok(_iApvService.getAppVersion(platform));
        }

    }
}
