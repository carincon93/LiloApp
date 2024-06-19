using LiloApp.Data;
using SQLite;

namespace LiloApp.Services
{
    public class PetService
    {
        private readonly SQLiteAsyncConnection _database;

        public PetService(SQLiteAsyncConnection database)
        {
            _database = database;
            _database.CreateTableAsync<PetData>().Wait();
        }

        public Task<List<PetData>> GetPetAsync()
        {
            return _database.Table<PetData>().ToListAsync();
        }

        public Task<int> SavePetAsync(PetData pet)
        {
            if (pet.Id != 0)
            {
                return _database.UpdateAsync(pet);
            }
            else
            {
                return _database.InsertAsync(pet);
            }
        }

        public Task<int> DeletePetAsync(PetData pet)
        {
            return _database.DeleteAsync(pet);
        }
    }
}
