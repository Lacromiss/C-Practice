using System;

namespace Tekrar6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carCount = GetInputInt("Mashin sayini daxil edin:", 3);

            Car[] cars = new Car[carCount];

            for (int i = 0; i < carCount; i++)
            {
                string brand = GetInputStr("Brand:", 3);
                string color = GetInputStr("Color:", 3);
                double millage = GetInputDouble("Millage:", 0);
                double fuelCapacity = GetInputDouble("Fuel capacity:", 150);
                double fuelFor1Km = GetInputDouble("Fuel for 1km:", 1);
                double currentFuel = GetInputDouble("Current fuel:", 0);


                cars[i] = new Car()
                {
                    Brand = brand,
                    Color = color,
                    FuelCapacity = fuelCapacity,
                    FuelFor1km = fuelFor1Km,
                    CurrentFuel = currentFuel,
                    Millage = millage

                };
            }

            bool check = true;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Masinlari millage-e gore filtirle");
                Console.WriteLine("2. Butun masinlari goster");
                Console.WriteLine("3. Prosesi bitir");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        double minMillage = GetInputDouble("Min millage:", 0);
                        double maxMillage = GetInputDouble("Max millage:", 0);

                        
                        foreach (var car in FilterByMillage(cars, minMillage, maxMillage))
                        {
                            Console.WriteLine("------");
                            car.ShowInfo();
                        }

                        break;
                    case "2":
                        foreach (var car in cars)
                        {
                            Console.WriteLine("------");
                            car.ShowInfo();
                        }
                        break;
                    case "3":

                        check = false;
                        break;
                    default:
                        Console.WriteLine("bele bir emeliyyat yoxdur");

                        break;
                }
            } while (check);

        }

        static Car[] FilterByMillage(Car[] cars, double minMillage, double maxMillage)
        {

            Car[] filteredCars = new Car[0];
            if (cars != null && cars.Length > 0)
            {
                foreach (var car in cars)
                {
                    if (car.Millage >= minMillage && car.Millage <= maxMillage)
                    {
                        Array.Resize(ref filteredCars, filteredCars.Length + 1);
                        filteredCars[filteredCars.Length - 1] = car;
                    }

                }
            }

            return filteredCars;
        }

        static int GetInputInt(string name, int min, int max = int.MaxValue)
        {
            int input;
            bool isNum;
            do
            {
                Console.WriteLine(name);
                string inputStr = Console.ReadLine();
                isNum = int.TryParse(inputStr, out input); 

            } while (!isNum || input < min || input > max);

            return input;
        }

        static double GetInputDouble(string name, double min, double max = double.MaxValue)
        {
            double input;
            bool isNum;
            do
            {
                Console.WriteLine(name);
                string inputStr = Console.ReadLine();
                isNum = double.TryParse(inputStr, out input);

            } while (!isNum || input < min || input > max);

            return input;
        }

        static string GetInputStr(string name, int min, int max = int.MaxValue)
        {
            string input;
            do
            {
                Console.WriteLine(name);
                input = Console.ReadLine();
            } while (input.Length < min || input.Length > max);

            return input;
        }
    }
}