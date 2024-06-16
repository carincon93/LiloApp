using LiloApp.Data;
using SQLite;

namespace LiloApp.Services
{
	public class DreamCalendarService
	{
		private readonly SQLiteAsyncConnection _database;

		public DreamCalendarService(SQLiteAsyncConnection database)
		{
			_database = database;
			_database.CreateTableAsync<DreamCalendarData>().Wait();
		}

		public Task<List<DreamCalendarData>> GetDreamCalendarAsync()
		{
			return _database.Table<DreamCalendarData>().ToListAsync();
		}

		public Task<int> SaveDreamCalendarAsync(DreamCalendarData dreamCalendar)
		{
			if (dreamCalendar.Id != 0)
			{
				return _database.UpdateAsync(dreamCalendar);
			}
			else
			{
				return _database.InsertAsync(dreamCalendar);
			}
		}

		public Task<int> DeleteDreamCalendarAsync(DreamCalendarData dreamCalendar)
		{
			return _database.DeleteAsync(dreamCalendar);
		}
	}
}
