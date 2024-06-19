using LiloApp.Data;
using SQLite;

namespace LiloApp.Services
{
    public class OwnerService
    {
        private readonly SQLiteAsyncConnection _database;

        public OwnerService(SQLiteAsyncConnection database)
        {
            _database = database;
            _database.CreateTableAsync<OwnerData>().Wait();
        }

        public Task<List<OwnerData>> GetOwnerAsync()
        {
            return _database.Table<OwnerData>().ToListAsync();
        }

        public Task<int> SaveOwnerAsync(OwnerData owner)
        {
            if (owner.Id != 0)
            {
                return _database.UpdateAsync(owner);
            }
            else
            {
                return _database.InsertAsync(owner);
            }
        }

        public Task<int> DeleteOwnerAsync(OwnerData owner)
        {
            return _database.DeleteAsync(owner);
        }
    }
}
