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

            #region pari arrayta
            Console.WriteLine("printataan ekaa arrayta");
            Car[] carsOne = new Car[3] {auto1, auto3, auto5};
            foreach (Car carsArrayOne in carsOne)
            {
                
                Console.WriteLine(carsArrayOne.brand);
                Console.WriteLine(carsArrayOne.kilometers);
            }
            
            Console.WriteLine("\nprintataan tokaa arrayta");
            Car[] carsTwo = { auto2, auto3, auto4 };
            carsTwo[0].AddKilometers();
            carsTwo[1].AddKilometers();
            carsTwo[0].taxPaid = true;
            carsTwo[1].taxPaid = true;
            carsTwo[2].taxPaid = false;
            foreach (Car carsArrayTwo in carsTwo)
            {
                Console.WriteLine(carsArrayTwo.brand);
                Console.WriteLine(carsArrayTwo.kilometers);
            }

            carsTwo.SetValue(auto5, 0);
            Console.WriteLine("\nprintataan muutettua carsTwo arrayta: " + carsTwo.Length);
           
            Console.WriteLine("\nprintataan tokaa arrayta muutoksilla");
            foreach (Car carsArrayTwo in carsTwo)
            {
                if (carsArrayTwo.taxPaid == true)
                {
                    Console.WriteLine(carsArrayTwo.brand);
                    Console.WriteLine(carsArrayTwo.kilometers);
                    Console.WriteLine(carsArrayTwo.taxPaid);
                }
            }
            #endregion pari arrayta

            string[] items = { "Radio,", "Tape player,", "Wunderbaum" };

            foreach (Car carsArrayTwo in carsTwo)
            {
                carsArrayTwo.GetItems(items);
            }

            foreach (Car carsArrayTwo in carsTwo)
            {
                carsArrayTwo.PrintCarData();
            }
            
            foreach (Car carsArrayOne in carsOne)
            {
                carsArrayOne.PrintCarData();
            }
        }
    }
}
