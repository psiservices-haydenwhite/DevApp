using App.Adapters;
using App.Models;

namespace App.UseCases
{
    [TransientService]
    public class AddDeveloper
    {
        private readonly DevDBAdapter _devDBAdapter;

        public AddDeveloper(DevDBAdapter devDBAdapter)
        {
            _devDBAdapter = devDBAdapter;
        }

        public async Task Execute(Developer model)
        {
            await _devDBAdapter.AddDeveloper(model);
        }
    }
}