using SQLite;

namespace LiloApp.Data
{
	[Table("TrainingSession")]
	public class TrainingSessionData
	{
		[PrimaryKey]
		[AutoIncrement]
		[Column("id")]
		public int Id { get; set; }

		[Column("set")]
		public int Set { get; set; }

		[Column("reps")]
		public int Reps { get; set; }

		[Column("weight")]
		public int Weight { get; set; }

		[Column("exerciseId")]
		public int ExerciseId { get; set; }

		[Column("date")]
		public DateTime Date { get; set; }
	}
}
