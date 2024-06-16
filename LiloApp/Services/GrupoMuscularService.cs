using LiloApp.Data;
using SQLite;

namespace LiloApp.Services
{
	public class GrupoMuscularService
	{
		private readonly SQLiteAsyncConnection _database;

		public GrupoMuscularService(SQLiteAsyncConnection database)
		{
			_database = database;
			_database.CreateTableAsync<GrupoMuscularData>().Wait();
		}

		public Task<List<GrupoMuscularData>> GetGrupoMuscularAsync()
		{
			return _database.Table<GrupoMuscularData>().ToListAsync();
		}

		public Task<int> SaveGrupoMuscularAsync(GrupoMuscularData grupoMuscular)
		{
			if (grupoMuscular.Id != 0)
			{
				return _database.UpdateAsync(grupoMuscular);
			}
			else
			{
				return _database.InsertAsync(grupoMuscular);
			}
		}

		public Task<int> DeleteGrupoMuscularAsync(GrupoMuscularData grupoMuscular)
		{
			return _database.DeleteAsync(grupoMuscular);
		}
	}
}
