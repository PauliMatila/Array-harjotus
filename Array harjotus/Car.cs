using System;
using System.Collections.Generic;
using System.Text;

namespace Array_harjotus
{
    public class Car
    {
        public string brand;
        public int kilometers;
        public bool taxPaid;

        public Car()
        {

        }
        
        public Car(string brand, int kilometers)
        {
            this.brand = brand;
            this.kilometers = kilometers;
        }

        public void AddKilometers()
        {
            kilometers += 3;
        }

        public void PrintCarData()
        {
            Console.WriteLine($"Auton merkki on: {brand}.");
            Console.WriteLine($"Autolla on ajettu: {kilometers}.");
            Console.WriteLine($"Onko auton verot maksettu?: {taxPaid}");
        }

        
    }
}
