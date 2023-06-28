using App.Adapters;
using App.Models;

namespace App.UseCases.Games
{
    [TransientService]
    public class GetGameById
    {
        private readonly GameDBAdapter _gameDBAdapter;

        public GetGameById(GameDBAdapter gameDBAdapter)
        {
            _gameDBAdapter = gameDBAdapter;
        }

        public async Task<Game> Execute(int id) => await _gameDBAdapter.GetGameById(id);
    }
}
