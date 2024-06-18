using LiloApp.Data;
using SQLite;

namespace LiloApp.Services
{
    public class MascotaService
    {
        private readonly SQLiteAsyncConnection _database;

        public MascotaService(SQLiteAsyncConnection database)
        {
            _database = database;
            _database.CreateTableAsync<MascotaData>().Wait();
        }

        public Task<List<MascotaData>> GetMascotaAsync()
        {
            return _database.Table<MascotaData>().ToListAsync();
        }

        public Task<int> SaveMascotaAsync(MascotaData mascota)
        {
            if (mascota.Id != 0)
            {
                return _database.UpdateAsync(mascota);
            }
            else
            {
                return _database.InsertAsync(mascota);
            }
        }

        public Task<int> DeleteMascotaAsync(MascotaData mascota)
        {
            return _database.DeleteAsync(mascota);
        }
    }
}
