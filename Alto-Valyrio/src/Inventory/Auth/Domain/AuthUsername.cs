using Alto_Valyrio.src.Shared.Domain.ValueObject;
using System;

namespace Alto_Valyrio.src.Inventory.Auth.Domain
{
    public class AuthUsername : StringValueObject
    {
        public AuthUsername(string value) : base(value)
        {
            EnsureIsNotEmpty();
        }

        private void EnsureIsNotEmpty()
        {
            bool isEmpty = this.value == String.Empty;

            if (isEmpty)
            {
                throw new EmptyAuthUsernameException(null);
            }
        }
    }
}