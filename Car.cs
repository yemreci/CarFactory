namespace CarFactory
{
    internal abstract class Car
    {
        public string UID = Guid.NewGuid().ToString();
        public abstract string Type { get;}
        public string? CONTINENT;
        public override bool Equals(object obj)
        {
            if (obj is Car otherCar)
            {
                return Type == otherCar.Type;
            }

            return false;
        }
    }
}
