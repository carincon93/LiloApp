using LiloApp.Data;
using SQLite;

namespace LiloApp.Services
{
    public class AmoService
    {
        private readonly SQLiteAsyncConnection _database;

        public AmoService(SQLiteAsyncConnection database)
        {
            _database = database;
            _database.CreateTableAsync<AmoData>().Wait();
        }

        public Task<List<AmoData>> GetAmoAsync()
        {
            return _database.Table<AmoData>().ToListAsync();
        }

        public Task<int> SaveAmoAsync(AmoData amo)
        {
            if (amo.Id != 0)
            {
                return _database.UpdateAsync(amo);
            }
            else
            {
                return _database.InsertAsync(amo);
            }
        }

        public Task<int> DeleteAmoAsync(AmoData amo)
        {
            return _database.DeleteAsync(amo);
        }
    }
}
