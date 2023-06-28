using App.Adapters;
using App.Models;

namespace App.UseCases.Games
{
    [TransientService]
    public class DeleteGame
    {
        private readonly GameDBAdapter _gameDBAdapter;

        public DeleteGame(GameDBAdapter gameDBAdapter)
        {
            _gameDBAdapter = gameDBAdapter;
        }

        public async Task Execute(int id) => await _gameDBAdapter.DeleteGame(id);
    }
}
