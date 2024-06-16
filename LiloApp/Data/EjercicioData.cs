using SQLite;

namespace LiloApp.Data
{
	[Table("Ejercicio")]
	public class EjercicioData
	{
		[PrimaryKey]
		[AutoIncrement]
		[Column("id")]
		public int Id { get; set; }

		[Column("nombre")]
		public string Nombre { get; set; }

		[Column("grupoMuscularId")]
		public int GrupoMuscularId { get; set; }
	}
}
