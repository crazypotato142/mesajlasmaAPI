using mesajlasmaAPI.Data;
using mesajlasmaAPI.Data.Models;
using mesajlasmaAPI.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace mesajlasmaAPI.Services
{
	public class GrupServis
	{
		private mesajlasmadbcontext _db;
		public GrupServis()
		{
			_db = new mesajlasmadbcontext();
		}

		public async Task<Grup?> GetirListe()
		{
			return await _db.Grup.Include(i => i.Kullanicilar).FirstOrDefaultAsync();
		}

        public async Task<List<Grup>> GetirGrupListesi()
        {
            return await _db.Grup.ToListAsync();
        }

        public async Task<int> Gonder(GrupViewModel input)
        {
            Grup grup = new()
            {
                Adi = input.Adi,
            };

            await _db.Grup.AddAsync(grup);
            var result = _db.SaveChanges();
            return result;
        }
    }
}