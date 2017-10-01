using System;

namespace Inheritance
{
    public class F1Car : Car
    {
        public string Pilot { get; set; }

        public override void Accelerate(int newSpeed)
        {
            Console.WriteLine("Faster acceleration!");
            Speed = newSpeed;
        }

        public override string GetInfo()
        {
            var info = base.GetInfo();
            return $"{info} Pilot is {Pilot}.";
        }
    }
}