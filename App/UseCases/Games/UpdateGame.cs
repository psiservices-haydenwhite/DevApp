using App.Adapters;
using App.Models;

namespace App.UseCases.Games
{
    [TransientService]
    public class UpdateGame
    {
        private readonly GameDBAdapter _gameDBAdapter;

        public UpdateGame(GameDBAdapter gameDBAdapter)
        {
            _gameDBAdapter = gameDBAdapter;
        }

        public async Task Execute(int id, Game model) => await _gameDBAdapter.UpdateGame(id, model);
    }
}
