namespace Alto_Valyrio.src.Inventory.Warehouses.Applications
{
    public class WarehouseCommand
    {
        private readonly string Name;
        private readonly int StateId;
        private readonly int AddressStateId;

        public WarehouseCommand(string name, int stateId, int addressStateId)
        {
            Name = name;
            StateId = stateId;
            AddressStateId = addressStateId;
        }

        private string GetName() => this.Name;
        private int GetStateId() => this.StateId;
        private int GetAddressState() => this.AddressStateId;
    }
}
