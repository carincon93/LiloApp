using LiloApp.Data;
using SQLite;

namespace LiloApp.Services
{
	public class ExerciseService
	{
		private readonly SQLiteAsyncConnection _database;

		public ExerciseService(SQLiteAsyncConnection database)
		{
			_database = database;
			_database.CreateTableAsync<ExerciseData>().Wait();
		}

		public Task<List<ExerciseData>> GetExerciseAsync()
		{
			return _database.Table<ExerciseData>().ToListAsync();
		}

		public Task<int> SaveExerciseAsync(ExerciseData exercise)
		{
			if (exercise.Id != 0)
			{
				return _database.UpdateAsync(exercise);
			}
			else
			{
				return _database.InsertAsync(exercise);
			}
		}

		public Task<int> DeleteExerciseAsync(ExerciseData exercise)
		{
			return _database.DeleteAsync(exercise);
		}
	}
}
