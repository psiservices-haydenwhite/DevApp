using App.Adapters;
using App.Models;

namespace App.UseCases.Developers
{
    [TransientService]
    public class DeleteDeveloper
    {
        private readonly DevDBAdapter _devDBAdapter;

        public DeleteDeveloper(DevDBAdapter devDBAdapter)
        {
            _devDBAdapter = devDBAdapter;
        }
        public async Task Execute(int id) => await _devDBAdapter.DeleteDeveloper(id);
    }
}
