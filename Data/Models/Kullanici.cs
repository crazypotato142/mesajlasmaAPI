namespace mesajlasmaAPI.Data.Models
{
	public class Kullanici
	{
		public int Id { get; set; }
		public string Adi { get; set; } = null!;
		public string Soyadi { get; set; } = null!;
		public string KullaniciAdi { get; set; } = null!;
		public int? GrupId { get; set; }

		public virtual ICollection<Mesaj> Mesajlar { get; set; }
		public virtual Grup Grup { get; set; }
	}
}