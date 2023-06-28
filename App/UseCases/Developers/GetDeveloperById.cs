using App.Adapters;
using App.Models;

namespace App.UseCases.Developers
{
    [TransientService]
    public class GetDeveloperById
    {
        private readonly DevDBAdapter _devDBAdapter;

        public GetDeveloperById(DevDBAdapter devDBAdapter)
        {
            _devDBAdapter = devDBAdapter;
        }

        public async Task<Developer> Execute(int id) => await _devDBAdapter.GetDeveloperById(id);
    }
}