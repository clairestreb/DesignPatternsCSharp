using System;

namespace Domain.FactoryPatterns
{
    public class Car : IMachine
    {
        public string Name
        {
            get { return "car"; }
        }

        public void TurnOn()
        {
            Console.WriteLine("Car is starting.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Car is stopping.");
        }
    }
}