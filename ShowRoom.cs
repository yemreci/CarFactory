namespace CarFactory
{
    internal class ShowRoom
    {
        public List<Car> Cars { get; set; }
        public ShowRoom()
        {
            Cars = new List<Car>();
        }
        public void OrderCarFromList(string type,string boughtContinent)
        {
            Car orderedCar = Cars.FirstOrDefault(car => car.Type == type);

            if (orderedCar == null)
            {
                throw new ArgumentException("Car type not found in showroom.", nameof(type));
            }

            PrepareBoughtCar(orderedCar);
            SendBoughtCar(orderedCar, boughtContinent);
        }
        public void AddCarToList(Car car)
        {
            Cars.Add(car);
        }
        public void RemoveCarFromList(Car car)
        {
            Cars.Remove(car);
        }
        public void DisplayCars()
            Console.WriteLine("Cars in the showroom:");
            foreach (Car car in Cars)
            {
                Console.WriteLine("Car Type: {0}, Car UID: {1}", car.Type, car.UID);
            }
        }
        private void PrepareBoughtCar(Car car)
        {
            Console.WriteLine("Car Type: {0}, Car UID: {1} has been prepared", car.Type, car.UID);
        }
        private void SendBoughtCar(Car car, string boughtContinent)
        {
            Console.WriteLine("Car Type: {0}, Car UID: {1} has been shipped from {2} to {3}", car.Type, car.UID, car.CONTINENT,boughtContinent);
            Cars.Remove(car);
        }
    }
}
