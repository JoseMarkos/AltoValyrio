namespace Alto_Valyrio.src.Inventory.Warehouses.Domain
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public WarehouseState State { get; set; }
        public int AddressStateId { get; set; }
        public WarehouseAddressState AddressState { get; set; }
#nullable enable
        public string? Address { get; set; }
        public int? Telephone { get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }
#nullable disable
    }
}
