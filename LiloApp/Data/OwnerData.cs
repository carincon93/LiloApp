using SQLite;

namespace LiloApp.Data
{
    public class OwnerData
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
