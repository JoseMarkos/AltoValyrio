using Alto_Valyrio.src.Shared.Domain.ValueObject;

namespace Alto_Valyrio.src.Inventory.Products.Domain
{
    public class ProductLocation : IntValueObject
    {
        public ProductLocation(int value) : base(value)
        {
            EnsureValuoIsNotEmpty(this.GetType().Name, value);

            this.value = value + 1;
        }

        public void EnsureValuoIsNotEmpty(string fieldName, int value)
        {
            if (value == -1)
            {
                throw new EmptyFieldException(fieldName);
            }
        }
    }
}
