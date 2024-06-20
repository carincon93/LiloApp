using LiloApp.Data;
using SQLite;

namespace LiloApp.Services
{
    public class PetLifeService
    {
        private readonly SQLiteAsyncConnection _database;

        public PetLifeService(SQLiteAsyncConnection database)
        {
            _database = database;
            _database.CreateTableAsync<PetLifeData>().Wait();
        }

        public Task<List<PetLifeData>> GetPetLifeAsync()
        {
            return _database.Table<PetLifeData>().ToListAsync();
        }

        public Task<int> SavePetLifeAsync(PetLifeData petLife)
        {
            if (petLife.Id != 0)
            {
                return _database.UpdateAsync(petLife);
            }
            else
            {
                return _database.InsertAsync(petLife);
            }
        }

        public Task<int> DeletePetLifeAsync(PetLifeData petLife)
        {
            return _database.DeleteAsync(petLife);
        }
    }
}
