using LiloApp.Data;
using SQLite;

namespace LiloApp.Services
{
	public class TrainingSessionService
	{
		private readonly SQLiteAsyncConnection _database;

		public TrainingSessionService(SQLiteAsyncConnection database)
		{
			_database = database;
			_database.CreateTableAsync<TrainingSessionData>().Wait();
		}

		public Task<List<TrainingSessionData>> GetTrainingSessionAsync()
		{
			return _database.Table<TrainingSessionData>().ToListAsync();
		}

		public Task<int> SaveTrainingSessionAsync(TrainingSessionData trainingSession)
		{
			if (trainingSession.Id != 0)
			{
				return _database.UpdateAsync(trainingSession);
			}
			else
			{
				return _database.InsertAsync(trainingSession);
			}
		}

		public Task<int> DeleteTrainingSessionAsync(TrainingSessionData trainingSession)
		{
			return _database.DeleteAsync(trainingSession);
		}
	}
}
