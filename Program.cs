namespace CarFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ShowRoom showRoom = new ShowRoom();
            showRoom.AddCarToList(CarFactory.CreateCar("4x4"));
            showRoom.DisplayCars();
            showRoom.AddCarToList(CarFactory.CreateCar("Sport"));
            showRoom.AddCarToList(CarFactory.CreateCar("4x4"));
            showRoom.DisplayCars();
            showRoom.AddCarToList(CarFactory.CreateCar<AmericaCar>());
            showRoom.DisplayCars();
            showRoom.OrderCarFromList("4x4","Africa");
            showRoom.DisplayCars();

        }
    }
}