namespace mesajlasmaAPI.Data.Models
{
	public class Mesaj
	{
		public int Id { get; set; }
		public int GonderenId { get; set; }
		public int AlanId { get; set; }
		public string Metin { get; set; } = null!;
		public DateTime? Tarih { get; set; } = null!;
		public int? GrupId { get; set; }

		public virtual Grup Grup { get; set; }
	}
}
