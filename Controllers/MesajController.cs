using mesajlasmaAPI.Services;
using mesajlasmaAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace mesajlasmaAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MesajController : ControllerBase
	{
        [HttpGet]
        public async Task<IActionResult> GetirListe()
        {
            MesajServis servis = new();
            var result = await servis.GetirMesajListesi();
            return Ok(result);
        }

        [HttpPost("MesajGonder")]
		public async Task<IActionResult> MesajGonder([FromBody] MesajViewModel mesaj)
		{
			MesajServis _servis = new();
			var result = await _servis.Gonder(mesaj);
			return Ok(result);
		}

		[HttpPost("TopluMesajGonder")]
		public async Task<IActionResult> TopluMesajGonder([FromBody] List<MesajViewModel> mesaj)
		{
			MesajServis _servis = new();
			var result = await _servis.TopluGonder(mesaj);
			return Ok(result);
		}

		[HttpPost("GrupMesajGonder")]
		public async Task<IActionResult> GrupMesajGonder([FromBody] MesajViewModel mesaj)
		{
			MesajServis _servis = new();
			var result = await _servis.GrupGonder(mesaj);
			return Ok(result);
		}
	}
}