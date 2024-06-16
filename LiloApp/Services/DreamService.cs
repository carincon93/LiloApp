using LiloApp.Data;
using SQLite;

namespace LiloApp.Services
{
	public class DreamService
	{
		private readonly SQLiteAsyncConnection _database;

		public DreamService(SQLiteAsyncConnection database)
		{
			_database = database;
			_database.CreateTableAsync<DreamData>().Wait();
		}

		public Task<List<DreamData>> GetDreamsAsync()
		{
			return _database.Table<DreamData>().ToListAsync();
		}

		public Task<int> SaveDreamAsync(DreamData dream)
		{
			if (dream.Id != 0)
			{
				return _database.UpdateAsync(dream);
			}
			else
			{
				return _database.InsertAsync(dream);
			}
		}

		public Task<int> DeleteDreamAsync(DreamData dream)
		{
			return _database.DeleteAsync(dream);
		}
	}
}
