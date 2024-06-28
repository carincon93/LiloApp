using LiloApp.Data;
using SQLite;

namespace LiloApp.Services
{
    public class LanguagePracticeService
    {
        private readonly SQLiteAsyncConnection _database;

        public LanguagePracticeService(SQLiteAsyncConnection database)
        {
            _database = database;
            _database.CreateTableAsync<LanguagePracticeData>().Wait();
        }

        public Task<List<LanguagePracticeData>> GetLanguagePracticeAsync()
        {
            return _database.Table<LanguagePracticeData>().ToListAsync();
        }

        public Task<int> SaveLanguagePracticeAsync(LanguagePracticeData languagePractice)
        {
            if (languagePractice.Id != 0)
            {
                return _database.UpdateAsync(languagePractice);
            }
            else
            {
                return _database.InsertAsync(languagePractice);
            }
        }

        public Task<int> DeleteLanguagePracticeAsync(LanguagePracticeData languagePractice)
        {
            return _database.DeleteAsync(languagePractice);
        }
        
        public Task<LanguagePracticeData> GetLanguagePracticeByDayAndWeekAsync(int day, int week, string language)
        {
            return _database.Table<LanguagePracticeData>()
                            .Where(lp => lp.Day == day && lp.Week == week && lp.Language == language)
                            .FirstOrDefaultAsync();
        }
    }

}
