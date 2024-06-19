using LiloApp.Data;
using SQLite;

namespace LiloApp.Services
{
	public class MuscleGroupService
	{
		private readonly SQLiteAsyncConnection _database;

		public MuscleGroupService(SQLiteAsyncConnection database)
		{
			_database = database;
			_database.CreateTableAsync<MuscleGroupData>().Wait();
		}

		public Task<List<MuscleGroupData>> GetMuscleGroupAsync()
		{
			return _database.Table<MuscleGroupData>().ToListAsync();
		}

		public Task<int> SaveMuscleGroupAsync(MuscleGroupData muscleGroup)
		{
			if (muscleGroup.Id != 0)
			{
				return _database.UpdateAsync(muscleGroup);
			}
			else
			{
				return _database.InsertAsync(muscleGroup);
			}
		}

		public Task<int> DeleteMuscleGroupAsync(MuscleGroupData muscleGroup)
		{
			return _database.DeleteAsync(muscleGroup);
		}
	}
}
