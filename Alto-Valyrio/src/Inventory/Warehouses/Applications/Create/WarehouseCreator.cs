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

        public void Create(string name, int stateId, int addressStateId, string address, int telephone, string email, string description)
        {
            EnsureWarehouseNotExists(name);

            var warehouse = new Warehouse()
            {
                Name = name,
                StateId = stateId,
                AddressStateId = addressStateId,
                Address = address,
                Telephone = telephone,
                Email = email,
                Description = description
            };

            Repository.Save(warehouse);
        }

        private void EnsureWarehouseNotExists(string name)
        {
            var match = Repository.Search(name);

            if (!(match is null))
            {
                throw new InvalidWarehouseException();
            }
        }
    }
}
