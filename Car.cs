using System;
namespace Constructors_2
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being started. {0}", registrationNumber);
        }
    }
}

