using mesajlasmaAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace mesajlasmaAPI.Data
{
	public class mesajlasmadbcontext : DbContext
	{
        public mesajlasmadbcontext()
        {
            
        }
        public mesajlasmadbcontext(DbContextOptions<mesajlasmadbcontext> options) : base(options) { }

		public virtual DbSet<Kullanici> Kullanici { get; set; }
		public virtual DbSet<Grup> Grup { get; set; }
		public virtual DbSet<Mesaj> Mesaj { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost; Database=mesajlasma; Trusted_Connection=true;");
		}
	}
}
