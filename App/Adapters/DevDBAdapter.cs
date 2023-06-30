using App.Models;
using Insight.Database;

namespace App.Adapters
{
    [DatabaseService("DevApp")]
    public abstract class DevDBAdapter
    {
        [Sql("GetAllDevelopers", Schema = "dbo")]
        public abstract Task<IEnumerable<Developer>> GetAllDevelopers();

        [Sql("GetDeveloperById", Schema = "dbo")]
        public abstract Task<Developer> GetDeveloperById(int id);

        [Sql("GetDeveloperByName", Schema = "dbo")]
        public abstract Task<Developer> GetDeveloperByName(string name);

        [Sql("GetDeveloperGames", Schema = "dbo")]
        public abstract Task<IEnumerable<Game>> GetDeveloperGames(string name, string rating = "All");

        [Sql("AddDeveloper", Schema = "dbo")]
        public abstract Task AddDeveloper(NewDeveloper model);

        [Sql("UpdateDeveloper", Schema = "dbo")]
        public abstract Task UpdateDeveloper(int id, Developer model);

        [Sql("DeleteDeveloper", Schema = "dbo")]
        public abstract Task DeleteDeveloper(int id);
    }
}
