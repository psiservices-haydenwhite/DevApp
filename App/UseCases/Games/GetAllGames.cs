using App.Adapters;
using App.Models;

namespace App.UseCases.Games
{
    [TransientService]
    public class GetAllGames
    {
        private readonly GameDBAdapter _gameDBAdapter;

        public GetAllGames(GameDBAdapter gameDBAdapter)
        {
            _gameDBAdapter = gameDBAdapter;
        }

        public Task<IEnumerable<Game>> Execute() => _gameDBAdapter.GetAllGames();
    }
}
