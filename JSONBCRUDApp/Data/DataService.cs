using JSONBCRUDApp.Models;
using Microsoft.EntityFrameworkCore;

namespace JSONBCRUDApp.Data
{
    public interface IDataService
    {
        Task AddData(DataModel dataModel);
        Task<List<DataModel>> GetAllData();
        Task<string> GetName(int id);
    }
    public class DataService : IDataService
    {
        private readonly JsonDBContext _jsonDBContext;
        public DataService(JsonDBContext jsonDBContext) { 
            _jsonDBContext = jsonDBContext;
        }
        public async Task<List<DataModel>> GetAllData()
        {
            return await _jsonDBContext.DataModels.ToListAsync();
        }

        public async Task AddData(DataModel dataModel)
        {
            _jsonDBContext.DataModels.Add(dataModel);
            await _jsonDBContext.SaveChangesAsync();
        }

        public async Task<string> GetName(int id)
        {
            var data = await _jsonDBContext.DataModels.FirstOrDefaultAsync(t => t.Id == id);
            return data.Data.Name;
        }
    }
}
