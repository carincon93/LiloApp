using SQLite;

namespace LiloApp.Data
{
    [Table("Dream")]
    public class DreamData
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("title")]
        public string Title { get; set; } = string.Empty;

        [Column("isPrivate")]
        public bool IsPrivate { get; set; }
    }
}
