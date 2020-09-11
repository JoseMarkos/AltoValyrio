using Alto_Valyrio.src.Inventory.Warehouses.Domain;

namespace Alto_Valyrio.src.Inventory.Warehouses.Applications.Create
{
    public class WarehouseCreator : ICreator
    {
        private readonly IWarehouseRepository Repository;

        public WarehouseCreator(IWarehouseRepository repository)
        {
            Repository = repository;
        }

        public void Create(string name, int stateId, int addressStateId, int telephone, string email, string description)
        {
            var warehouse = new Warehouse()
            {
                Name = name,
                StateId = stateId,
                AddressStateId = addressStateId,
                Telephone = telephone,
                Email = email,
                Description = description
            };

            Repository.Save(warehouse);
        }

        private void EnsureWarehouseNotExists(int id)
        {
            var match = Repository.Search(id);

            if (!(match is null))
            {
//                throw new InvalidUsernameException(username.GetValue());
            }
        }

    }
}
