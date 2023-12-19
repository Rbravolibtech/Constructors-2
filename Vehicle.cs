using System;
namespace Constructors_2
{
    public class Vehicle
    {
        public readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("vehicle is being started");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }

}