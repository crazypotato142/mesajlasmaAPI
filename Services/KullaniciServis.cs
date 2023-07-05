using mesajlasmaAPI.Data;
using mesajlasmaAPI.Data.Models;
using mesajlasmaAPI.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace mesajlasmaAPI.Services
{
	public class KullaniciServis
	{
		private mesajlasmadbcontext _db;
		public KullaniciServis()
		{
			_db = new mesajlasmadbcontext();
		}

		public async Task<List<Kullanici>> GetirKullaniciListesi()
		{
			return await _db.Kullanici.ToListAsync();
		}
        public async Task<int> Gonder(KullaniciViewModel input)
        {
            Kullanici kullanici = new()
            {
                Adi = input.Adi,
                Soyadi = input.Soyadi,
                KullaniciAdi = input.KullaniciAdi,
            };

            await _db.Kullanici.AddAsync(kullanici);
            var result = _db.SaveChanges();
            return result;
        }
    }
}
