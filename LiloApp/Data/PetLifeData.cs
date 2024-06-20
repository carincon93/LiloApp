using SQLite;

namespace LiloApp.Data
{
    [Table("PetLifeData")]
    public class PetLifeData
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("dayNumber")]
        public int DayNumber { get; set; }

        [Column("diff")]
        public int Diff { get; set; }
    }
}
