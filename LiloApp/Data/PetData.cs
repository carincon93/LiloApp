using SQLite;

namespace LiloApp.Data
{
	[Table("Pet")]
	public class PetData
	{
		[PrimaryKey]
		[AutoIncrement]
		[Column("id")]
		public int Id { get; set; }

		[Column("animal")]
		public string Animal { get; set; }

		[Column("name")]
		public string Name { get; set; }

		[Column("life")]
		public int Life { get; set; }
    }
}
