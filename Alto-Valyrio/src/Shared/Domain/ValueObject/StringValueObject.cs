using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Shared.Domain.ValueObject
{
    public abstract class StringValueObject
    {
        protected string value;

        public StringValueObject(string value)
        {
            this.value = value;
        }

        public string GetValue()
        {
            return this.value;
        }

        public override string ToString()
        {
            return this.value;
        }
    }
}
