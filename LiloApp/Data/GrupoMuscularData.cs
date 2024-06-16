using SQLite;

namespace LiloApp.Data
{
	[Table("GrupoMuscular")]
	public class GrupoMuscularData
	{
		[PrimaryKey]
		[AutoIncrement]
		[Column("id")]
		public int Id { get; set; }

		[Column("nombre")]
		public string Nombre { get; set; }
	}
}
