using Microsoft.AspNetCore.Mvc;
using softplayer.application.Interfaces;
using System;
using System.Threading.Tasks;

namespace softplayer.api.calculo.juros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        private decimal juros=0m;

        private readonly IJurosService _appService;


        public JurosController(IJurosService appService)
        {
            _appService = appService;
        }


        [HttpGet("calculaJuros")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> getCalculos()
        {
            var vl_final = 0m;

            try
            {
             //   vl_final = valorinicial * (1 + _appService.GetJuros().juros) * tempo;

                var retorno = _appService.GetJuros();
                return Ok(new { taxa = retorno.juros });
            }
            catch (Exception e)
            {
                return BadRequest("Exception when calling: " + e.Message);
            }

        }


        [HttpPost("calculaJuros")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> getCalculo(decimal valorinicial,int tempo)
        {
            var vl_final = 0m; 
            try
            {
                var _valorinicial =  decimal.ToDouble(valorinicial);
                var taxa = decimal.ToDouble(_appService.GetJuros().juros);

                double montante = _valorinicial * Math.Pow((1 + taxa), tempo);
                return Ok(new { vl_final = montante.ToString("F") });
            }
            catch (Exception e)
            {
                return BadRequest("Exception when calling: " + e.Message);
            }

        }
    }
}
