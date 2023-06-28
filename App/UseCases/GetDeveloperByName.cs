using App.Adapters;
using App.Models;

namespace App.UseCases
{
    [TransientService]
    public class GetDeveloperByName
    {
        private readonly DevDBAdapter _devDBAdapter;

        public GetDeveloperByName(DevDBAdapter devDBAdapter)
        {
            _devDBAdapter = devDBAdapter;
        }

        public async Task<Developer> Execute(string name) => await _devDBAdapter.GetDeveloperByName(name);
    }
}