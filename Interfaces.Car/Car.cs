namespace Interfaces.Car
{
    public class Car : AbstractVehicle, IVehicle
    {
        public Car(string make, string model, string year, int speed, int distance) : base(make, model, year, speed,
            distance)
        {
        }

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