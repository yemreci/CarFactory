using System;

namespace CarFactory
{
    internal static class CarFactory
    {

        public static Car CreateCar<TCar>() where TCar : Car, new()
        {
            return new TCar();
        }
        public static Car CreateCar(string carType)
        {
            switch (carType)
            {
                case "4x4":
                    return new AmericaCar();
                case "Sport":
                    return new EuropeCar();
                default:
                    throw new ArgumentException("Invalid car type.");
            }
        }
    }
}
