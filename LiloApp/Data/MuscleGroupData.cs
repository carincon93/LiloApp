using SQLite;

namespace LiloApp.Data
{
	[Table("MuscleGroup")]
	public class MuscleGroupData
	{
		[PrimaryKey]
		[AutoIncrement]
		[Column("id")]
		public int Id { get; set; }

		[Column("name")]
		public string Name { get; set; } = string.Empty;
    }
}
