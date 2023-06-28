using App.Adapters;
using App.Models;

namespace App.UseCases
{
    [TransientService]
    public class UpdateDeveloper
    {
        private readonly DevDBAdapter _devDBAdapter;

        public UpdateDeveloper(DevDBAdapter devDBAdapter)
        {
            _devDBAdapter = devDBAdapter;
        }

        public async Task Execute(int id, Developer model) => await _devDBAdapter.UpdateDeveloper(id, model);
    }
}