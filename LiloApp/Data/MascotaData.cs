using SQLite;

namespace LiloApp.Data
{
	[Table("Mascota")]
	public class MascotaData
	{
		[PrimaryKey]
		[AutoIncrement]
		[Column("id")]
		public int Id { get; set; }

		[Column("animal")]
		public string Animal { get; set; }

		[Column("nombre")]
		public string Nombre { get; set; }

		[Column("vida")]
		public int Vida { get; set; }
	}
}
