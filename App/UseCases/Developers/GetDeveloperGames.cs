using App.Adapters;
using App.Models;

namespace App.UseCases.Developers
{
    [TransientService]
    public class GetDeveloperGames
    {
        private readonly DevDBAdapter _devDBAdapter;

        public GetDeveloperGames(DevDBAdapter devDBAdapter)
        {
            _devDBAdapter = devDBAdapter;
        }

        public async Task<IEnumerable<Game>> Execute(string name, string rating) => await _devDBAdapter.GetDeveloperGames(name, rating);
    }
}