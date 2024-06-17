using SQLite;

namespace LiloApp.Data
{
	[Table("DreamCalendar")]
	public class DreamCalendarData
	{
		[PrimaryKey]
		[AutoIncrement]
		[Column("id")]
		public int Id { get; set; }

		[Column("dreamId")]
		public int DreamId { get; set; }

		[Column("numeroDia")]
		public int NumeroDia { get; set; }

		[Column("numeroMes")]
		public int NumeroMes { get; set; }

		[Column("year")]
		public int Year { get; set; }

		[Column("comentario")]
		public string Comentario { get; set; }
	}
}
