using App.Adapters;
using App.Models;

namespace App.UseCases.Games
{
    [TransientService]
    public class AddGame
    {
        private readonly GameDBAdapter _gameDBAdapter;

        public AddGame(GameDBAdapter gameDBAdapter)
        {
            _gameDBAdapter = gameDBAdapter;
        }

        public async Task Execute(Game model)
        {
            await _gameDBAdapter.AddGame(model);
        }
    }
}
