using SQLite;

namespace LiloApp.Data
{
    [Table("LanguagePractice")]
    public class LanguagePracticeData
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("text")]
        public string Text { get; set; } = string.Empty;

        [Column("week")]
        public int Week { get; set; }

        [Column("day")]
        public int Day { get; set; }

        [Column("language")]
        public string Language { get; set; }
    }
}
