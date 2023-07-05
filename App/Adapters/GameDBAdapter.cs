using App.Models;
using Insight.Database;

namespace App.Adapters
{
    [DatabaseService("DevApp")]
    public abstract class GameDBAdapter
    {
        [Sql("GetAllGames", Schema = "dbo")]
        public abstract Task<IEnumerable<Game>> GetAllGames();

        [Sql("GetGameById", Schema = "dbo")]
        public abstract Task<Game> GetGameById(int id);

        [Sql("GetGameByName", Schema = "dbo")]
        public abstract Task<Game> GetGameByName(string name, string developer);

        [Sql("GetGameDev", Schema = "dbo")]
        public abstract Task<Developer> GetGameDev(string name);

        [Sql("AddGame", Schema = "dbo")]
        public abstract Task AddGame(NewGame model);

        [Sql("UpdateGame", Schema = "dbo")]
        public abstract Task UpdateGame(int id, Game model);

        [Sql("DeleteGame", Schema = "dbo")]
        public abstract Task DeleteGame(int id);
    }
}
