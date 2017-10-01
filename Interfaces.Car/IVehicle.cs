namespace Interfaces.Car
{
    public interface IVehicle
    {
        void Go(int newDistance);

        void Accelerate(int newSpeed);

        void Stop();

        string GetInfo();
    }
}