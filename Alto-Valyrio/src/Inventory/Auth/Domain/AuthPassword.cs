using Alto_Valyrio.src.Shared.Domain.ValueObject;

namespace Alto_Valyrio.src.Inventory.Auth.Domain
{
    public class AuthPassword : StringValueObject
    {
        public AuthPassword(string value) : base(value)
        {

        }

        public bool IsEquals(AuthPassword other)
        {
            return value == other.value;
        }
    }
}