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
        
        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("esPrivado")]
        public bool EsPrivado { get; set; }
    }
}
