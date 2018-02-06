using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Apv.AV.Services.Shared;

namespace Apv.AV.Web.Controllers
{
    public class SharedController:Controller
    {
        private IApvSharedServices _iApvService;

        public SharedController(IApvSharedServices iApvService)
        {
            _iApvService = iApvService;
        }

        /// <summary>
        /// Gets the country global settings.
        /// </summary>
        /// <returns>The country global settings.</returns>
        [HttpGet("api/[controller]/countrySettings")]
        public IActionResult getCountryGlobalSettings()
        {
            try
            {
                return Ok(_iApvService.getCountryGlobalSettings());
            }
            catch(Exception ex)
            {
                
            }
            return BadRequest("Error retrieving country global settings");
        }

        /// <summary>
        /// Gets the country global setting.
        /// </summary>
        /// <returns>The country global setting.</returns>
        /// <param name="countryCode">Country code.</param>
        [HttpGet("api/[controller]/countrySettings/{countryCode}")]
        public IActionResult getCountryGlobalSetting(string countryCode)
        {
            try
            {
                return Ok(_iApvService.getCountryGlobalSetting(countryCode));
            }
            catch(Exception ex)
            {
                
            }

            return BadRequest("Error retrieving country global settings");
        }
    }
}
