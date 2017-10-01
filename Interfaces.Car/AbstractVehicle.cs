namespace Interfaces.Car
{
    public abstract class AbstractVehicle
    {
        protected AbstractVehicle(string make, string model, string year, int speed, int distance)
        {
            Make = make;
            Model = model;
            Year = year;
            Speed = speed;
            Distance = distance;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }

        public int Speed { get; set; }

        public int Distance { get; set; }
    }
}