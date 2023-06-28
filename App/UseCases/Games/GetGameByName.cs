using App.Adapters;
using App.Models;

namespace App.UseCases.Games
{
    [TransientService]
    public class GetGameByName
    {
        private readonly GameDBAdapter _gameDBAdapter;

        public GetGameByName(GameDBAdapter gameDBAdapter)
        {
            _gameDBAdapter = gameDBAdapter;
        }

        public async Task<Game> Execute(string name, string developer) => await _gameDBAdapter.GetGameByName(name, developer);
    }
}
