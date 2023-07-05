using mesajlasmaAPI.Services;
using mesajlasmaAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace mesajlasmaAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class KullaniciController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> GetirListe()
		{
			KullaniciServis servis = new();
			var result = await servis.GetirKullaniciListesi();
			return Ok(result);
		}
        [HttpPost("KullaniciOlustur")]
        public async Task<IActionResult> KullaniciGonder([FromBody] KullaniciViewModel kullanici)
        {
            KullaniciServis _servis = new();
            var result = await _servis.Gonder(kullanici);
            return Ok(result);
        }
    }
}