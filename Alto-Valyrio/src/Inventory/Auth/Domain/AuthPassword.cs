using Alto_Valyrio.src.Shared.Domain.ValueObject;
using System;

namespace Alto_Valyrio.src.Inventory.Auth.Domain
{
    public class AuthPassword : StringValueObject
    {
        public AuthPassword(string value) : base(value)
        {
            EnsureIsNotEmpty();
        }

        public bool IsEquals(AuthPassword other)
        {
            return value == other.value;
        }

        private void EnsureIsNotEmpty()
        {
            bool isEmpty = this.value == String.Empty;

            if (isEmpty)
            {
                throw new InvalidAuthPasswordException();
            }
        }
    }
}