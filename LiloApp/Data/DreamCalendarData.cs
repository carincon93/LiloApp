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

		[Column("dayNumber")]
		public int DayNumber { get; set; }

		[Column("monthNumber")]
		public int MonthNumber { get; set; }

		[Column("year")]
		public int Year { get; set; }

		[Column("comment")]
		public string Comment { get; set; } = string.Empty;
	}
}
