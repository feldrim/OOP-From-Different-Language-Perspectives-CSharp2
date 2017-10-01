namespace Basic
{
    public class Car
    {
        public Car(string make, string model, string year, int speed, int distance)
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

        public virtual void Go(int newDistance)
        {
            Distance += newDistance;
        }

        public virtual void Accelerate(int newSpeed)
        {
            Speed = newSpeed;
        }

        public virtual void Stop()
        {
            Speed = 0;
        }

        public virtual string GetInfo()
        {
            return $"Car Info: {Year} {Make} {Model}. Distance: {Distance} km. and traveling at {Speed} kmph.";
        }
    }
}