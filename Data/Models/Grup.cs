namespace mesajlasmaAPI.Data.Models
{
    public class Grup
    {
		public int Id { get; set; }
		public string Adi { get; set; } = null!;

		public virtual ICollection<Kullanici> Kullanicilar { get; set; }
		public virtual ICollection<Mesaj> Mesajlar { get; set; }

	}
}
