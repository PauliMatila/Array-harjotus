using System;

namespace Array_harjotus
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto1 = new Car();
            auto1.brand = "BMW";
            auto1.kilometers = 30100;
            auto1.taxPaid = true;
            
            Car auto2 = new Car();
            auto2.brand = "Toyota";
            auto2.kilometers = 177000;
            auto2.taxPaid = false;
            
            Car auto3 = new Car();
            auto3.brand = "Audi";
            auto3.kilometers = 123000;
            auto3.taxPaid = false;
            
            Car auto4 = new Car();
            auto4.brand = "Honda";
            auto4.kilometers = 87000;
            auto4.taxPaid = true;
            
            Car auto5 = new Car();
            auto5.brand = "Volkswagen";
            auto5.kilometers = 485000;
            auto5.taxPaid = false;

            Car[] carsOne = new Car[3] {auto1, auto3, auto5};
            foreach (Car carsArrayOne in carsOne)
            {
                Console.WriteLine(carsArrayOne.brand);
                Console.WriteLine(carsArrayOne.kilometers);
            }

            Car[] carsTwo = { auto2, auto3, auto4 };
            
        }
    }
}
