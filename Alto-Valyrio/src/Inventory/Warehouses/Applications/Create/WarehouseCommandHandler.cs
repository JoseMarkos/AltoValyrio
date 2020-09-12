using Alto_Valyrio.src.Inventory.Warehouses.Domain;

namespace Alto_Valyrio.src.Inventory.Warehouses.Applications.Create
{
    public class WarehouseCommandHandler
    {
        private readonly ICreator Creator;

        public WarehouseCommandHandler(ICreator creator)
        {
            Creator = creator;
        }

        public void Trigger(WarehouseCommand command)
        {
            Creator.Create(command.GetName()
                , command.GetStateId()
                , command.GetAddressState()
                , command.GetAddress()
                , command.GetTelephone()
                , command.GetEmail()
                , command.GetDescription());
        }
    }
}
