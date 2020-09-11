namespace Alto_Valyrio.src.Inventory.Warehouses.Applications.Create
{
    public class WarehouseCommand
    {
        private readonly string Name;
        private readonly int StateId;
        private readonly int AddressStateId;
        private readonly int Telephone;
        private readonly string Email;
        private readonly string Description;

        public WarehouseCommand(string name, int stateId, int addressStateId, int telephone, string email, string description)
        {
            Name = name;
            StateId = stateId;
            AddressStateId = addressStateId;
            Telephone = telephone;
            Email = email;
            Description = description;
        }

        public string GetName() => this.Name;
        public int GetStateId() => this.StateId;
        public int GetAddressState() => this.AddressStateId;
        public int GetTelephone() => this.Telephone;
        public string GetEmail() => this.Email;
        public string GetDescription() => this.Description;
    }
}
