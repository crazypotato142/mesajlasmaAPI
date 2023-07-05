using mesajlasmaAPI.Services;
using mesajlasmaAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace mesajlasmaAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class GrupController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> GetirListe()
		{
			GrupServis servis = new();
			var result = await servis.GetirGrupListesi();
			return Ok(result);
		}
        [HttpPost("GrupOlustur")]
        public async Task<IActionResult> GrupGonder([FromBody] GrupViewModel grup)
        {
            GrupServis _servis = new();
            var result = await _servis.Gonder(grup);
            return Ok(result);
        }
    }
}