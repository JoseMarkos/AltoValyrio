namespace Alto_Valyrio.src.Shared.Domain.ValueObject
{
    public abstract class IntValueObject
    {
        protected int value;

        public IntValueObject(int value)
        {
            this.value = value;
        }

        public int GetValue()
        {
            return this.value;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
