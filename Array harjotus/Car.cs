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
        public string[] items;

        
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
            Console.WriteLine("\n");
            Console.WriteLine($"Auton merkki on: {brand}.");
            Console.WriteLine($"Autolla on ajettu: {kilometers}.");
            Console.WriteLine($"Onko auton verot maksettu?: {taxPaid}");
            if (items != null && items.Length > 0)
            {
                Console.WriteLine($"Mitä herkkuja autosta löytyy?:");
                foreach (string item in items)
                {
                    Console.Write(item + " " );
                }
                Console.WriteLine("\n");
            }
        }

        public void GetItems(string[] swag)
        {
            this.items = swag;
        }
    }
}
