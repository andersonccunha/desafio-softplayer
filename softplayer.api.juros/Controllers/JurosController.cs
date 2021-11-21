using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using softplayer.application.Interfaces;
using softplayer.application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace softplayer.api.juros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {

        private readonly IJurosService _appService;
         
        public JurosController(IJurosService appService)
        {
            _appService = appService;
        }

        //private IJuros _juros;
        [HttpGet("taxaJuros")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> getTaxas()
        {
            try
            {
                var retorno = _appService.GetJuros();
                return Ok(new { taxa = retorno.juros });
            }
            catch (Exception e)
            {
                return BadRequest("Exception when calling: " + e.Message);
            }

        }

        [HttpPost("taxaJuros")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> setTaxas(decimal taxa)
        {
            try
            {
               var _taxa = new JurosViewModel(taxa);

                var retorno = _appService.GetJuros();

                if (retorno == null)
                { 
                    _appService.Add(_taxa); 
                }
                else
                {
                    _appService.Update(_taxa);
                }

                return Ok(new { taxa = _taxa.juros/100 });
            }
            catch (Exception e)
            {
                return BadRequest("Exception when calling: " + e.Message);
            }

        }

    }
}
