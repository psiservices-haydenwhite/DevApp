using App.Adapters;
using App.Models;

namespace App.UseCases
{
    [TransientService]
    public class GetAllDevelopers
    {
        private readonly DevDBAdapter _devDBAdapter;

        public GetAllDevelopers(DevDBAdapter devDBAdapter)
        {
            _devDBAdapter = devDBAdapter;
        }

        public Task<IEnumerable<Developer>> Execute() => _devDBAdapter.GetAllDevelopers();
    }
}
