using Alto_Valyrio.src.Inventory.Products.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Applications.Create
{
    public class ProductCommand
    {
        private readonly string Name;
        private readonly string Brand;
        private readonly int CategoryId;
        private readonly int PackingId;
        private readonly decimal Price;
        private readonly bool Refrigerated;
        private readonly DateTime ExpirationDate;
        private readonly double Weight;
        private readonly string Description;
        private readonly decimal TotalPrice;

        public ProductCommand(string name, string brand, int categoryId, int packingId, decimal price
            , bool refrigerated, DateTime expirationDate, double weight, string description, decimal totalPrice)
        {
            Name = name;
            Brand = brand;
            CategoryId = categoryId;
            PackingId = packingId;
            Price = price;
            Refrigerated = refrigerated;
            ExpirationDate = expirationDate;
            Weight = weight;
            Description = description;
            TotalPrice = totalPrice;
        }

        public string GetName => Name;

        public string GetBrand => Brand;

        public int GetCategoryId => CategoryId;

        public int GetPackingId => PackingId;

        public decimal GetPrice => Price;

        public bool GetRefrigerated => Refrigerated;

        public DateTime GetExpirationDate => ExpirationDate;

        public double GetWeight => Weight;

        public string GetDescription => Description;
        public decimal GetTotalPrice => TotalPrice;
    }
}
