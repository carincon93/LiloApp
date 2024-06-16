using SQLite;

namespace LiloApp.Data
{
	[Table("SesionEntrenamiento")]
	public class SesionEntrenamientoData
	{
		[PrimaryKey]
		[AutoIncrement]
		[Column("id")]
		public int Id { get; set; }

		[Column("serie")]
		public int Serie { get; set; }

		[Column("reps")]
		public int Reps { get; set; }

		[Column("peso")]
		public int Peso { get; set; }

		[Column("ejercicioId")]
		public int EjercicioId { get; set; }

		[Column("fecha")]
		public DateTime Fecha { get; set; }
	}
}
