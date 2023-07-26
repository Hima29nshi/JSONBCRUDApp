using JSONBCRUDApp.Models;
using Microsoft.EntityFrameworkCore;

namespace JSONBCRUDApp.Data
{
    public class JsonDBContext: DbContext
    {
        public JsonDBContext(DbContextOptions<JsonDBContext> options) : base(options) {}

        public DbSet<DataModel> DataModels { get; set; }
    }
}
