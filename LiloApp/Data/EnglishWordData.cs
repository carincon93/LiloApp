using SQLite;

namespace LiloApp.Data
{
    [Table("EnglishWord")]
    public class EnglishWordData
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public string Id { get; set; }

        [Column("word")]
        public string Word { get; set; } = string.Empty;

        [Column("translation")]
        public string Translation { get; set; } = string.Empty;

        [Column("week")]
        public int? Week { get; set; }
    }
}
