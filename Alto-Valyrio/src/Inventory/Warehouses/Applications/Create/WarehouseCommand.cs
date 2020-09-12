using System;

namespace Alto_Valyrio.src.Inventory.Warehouses.Applications.Create
{
    public class WarehouseCommand
    {
        private readonly string Name;
        private readonly int StateId;
        private readonly int AddressStateId;
        private readonly string Address;
        private readonly int Telephone;
        private readonly string Email;
        private readonly string Description;

        public WarehouseCommand(string name, int stateId, int addressStateId, string address, int telephone, string email, string description)
        {
            if (name == String.Empty)
            {
                throw new Exception("Please add a name.");
            }

            Name = name;
            StateId = stateId;
            AddressStateId = addressStateId;
            Address = address;
            Telephone = telephone;
            Email = email;
            Description = description;
        }

        public string GetName() => this.Name;
        public int GetStateId() => this.StateId;
        public int GetAddressState() => this.AddressStateId;
        public string GetAddress() => this.Address;
        public int GetTelephone() => this.Telephone;
        public string GetEmail() => this.Email;
        public string GetDescription() => this.Description;
    }
}
