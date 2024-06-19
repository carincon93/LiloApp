using SQLite;

namespace LiloApp.Data
{
	[Table("Excercise")]
	public class ExerciseData
	{
		[PrimaryKey]
		[AutoIncrement]
		[Column("id")]
		public int Id { get; set; }

		[Column("name")]
		public string Name { get; set; }

		[Column("muscleGroupId")]
		public int MuscleGroupId { get; set; }
	}
}
