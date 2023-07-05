using mesajlasmaAPI.Data;
using mesajlasmaAPI.Data.Models;
using mesajlasmaAPI.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace mesajlasmaAPI.Services
{
	public class MesajServis
	{
		private mesajlasmadbcontext _db;
		public MesajServis()
		{
			_db = new mesajlasmadbcontext();
		}

		public async Task<int> Gonder(MesajViewModel input)
		{
			Mesaj mesaj = new()
			{
				AlanId = input.AlanId,
				GonderenId = input.GonderenId,
				Metin = input.Metin,
				Tarih = DateTime.Now
			};

			await _db.Mesaj.AddAsync(mesaj);
			var result = _db.SaveChanges();
			return result;
		}

		public async Task<bool> TopluGonder(List<MesajViewModel> input)
		{
			try
			{
				foreach (var item in input)
				{
					await _db.Mesaj.AddAsync(new()
					{
						AlanId = item.AlanId,
						GonderenId = item.GonderenId,
						Metin = item.Metin,
						Tarih = DateTime.Now
					});
					_db.SaveChanges();
				}
				return true;
			}
			catch
			{
				return false;
			}

		}

        public async Task<bool> GrupGonder(MesajViewModel input)
		{
			if (input.GroupId.HasValue == false)
				return false;

			GrupServis grupServis = new();
			var getir_grup = await grupServis.GetirListe();
			var getir_grup_kullanicilar = getir_grup.Kullanicilar.Select(s => s.Id).ToList();

			try
			{
				foreach (var item in getir_grup_kullanicilar)
				{
					await _db.Mesaj.AddAsync(new()
					{
						AlanId = item,
						Metin = input.Metin,
						Tarih = DateTime.Now,
						GrupId = input.GroupId
					});
					_db.SaveChanges();
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
        public async Task<List<Mesaj>> GetirMesajListesi()
        {
            return await _db.Mesaj.ToListAsync();
        }
    }
}