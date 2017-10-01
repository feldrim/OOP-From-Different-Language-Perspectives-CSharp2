namespace Basic
{
    public class CarWasher
    {
        public string WashCar(Car car)
        {
            return $"Washing the car: {car.Make} {car.Model} of {car.Year}.";
        }
    }
}