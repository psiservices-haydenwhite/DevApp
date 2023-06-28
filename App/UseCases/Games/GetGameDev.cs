using App.Adapters;
using App.Models;

namespace App.UseCases.Games
{
    [TransientService]
    public class GetGameDev
    {
        private readonly GameDBAdapter _gameDBAdapter;

        public GetGameDev(GameDBAdapter gameDBAdapter)
        {
            _gameDBAdapter = gameDBAdapter;
        }

        public async Task<Developer> Execute(string name) => await _gameDBAdapter.GetGameDev(name);
    }
}
