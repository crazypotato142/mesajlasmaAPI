namespace mesajlasmaAPI.ViewModel
{
	public class MesajViewModel
	{
		public int GonderenId { get; set; }
		public int AlanId { get; set; }
		public string Metin { get; set; } = null!;
		public DateTime? Tarih { get; set; } = null!;
		public int? GroupId { get; set; }
	}
}