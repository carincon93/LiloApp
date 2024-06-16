using SQLite;

namespace LiloApp.Services
{
	public class LocalDatabaseService
	{
		public SQLiteAsyncConnection Database { get; }

		public LocalDatabaseService(string dbPath)
		{
			Database = new SQLiteAsyncConnection(dbPath);
		}
	}
}