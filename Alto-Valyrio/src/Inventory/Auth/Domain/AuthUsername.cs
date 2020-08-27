using Alto_Valyrio.src.Shared.Domain.ValueObject;

namespace Alto_Valyrio.src.Inventory.Auth.Domain
{
    public class AuthUsername : StringValueObject
    {
        public AuthUsername(string value) : base(value)
        {
        }
    }
}