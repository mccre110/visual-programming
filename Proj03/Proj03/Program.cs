using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Proj03
{
    class Program
    {
        public static List<Car> carList = new List<Car>();

        static void Main(string[] args)
        {
            try
            {
                ReadFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("File Not Read.");
            }

            Console.WriteLine("Welcome to a Car Inventory System");
            string menuChoice = "";
            while (menuChoice != "exit")
            {
                Console.WriteLine("Enter 'quit' to exit");
                Console.WriteLine("Would you like to 'view', 'add', or 'delete' records?: ");
                menuChoice = Console.ReadLine();

                if (menuChoice == "view")
                {
                    carList.ForEach(Console.WriteLine);
                }
                else if (menuChoice == "add")
                {
                    carList.Add(GetInput());
                }
                else if (menuChoice == "delete")
                {
                    carList.Remove(GetInput());
                }
                else if (menuChoice == "quit")
                {
                    try
                    {
                        WriteFile();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("File Not Written.");
                    }
                    menuChoice = "exit";
                }
                else
                {
                    Console.WriteLine("Try Again");
                    continue;
                }
            }

        }
        public static Car GetInput()
        {
            string make;
            string model;
            int year;
            string vin;

            while (true)
            {
                Console.WriteLine("Enter Car Make: ");
                make = Console.ReadLine();
                if (make.All(char.IsLetter))
                    break;
                else
                    Console.WriteLine("Try Again: ");

            }
            while (true)
            {
                Console.WriteLine("Enter Car Model: ");
                model = Console.ReadLine();
                if (model.All(char.IsLetter))
                    break;
                else
                    Console.WriteLine("Try Again: ");

            }
            while (true)
            {
                Console.WriteLine("Enter Car Year: ");
                string yearString = Console.ReadLine();
                if (int.TryParse(yearString, out year))
                    break;
                else
                    Console.WriteLine("Try Again: ");
            }
            while (true)
            {
                Console.WriteLine("Enter Car VIN: ");
                vin = Console.ReadLine();
                if (vin.All(char.IsLetterOrDigit))
                    break;
                else
                    Console.WriteLine("Try Again: ");
            }
            Car car = new Car(make, model, year, vin);
            return car;
        }

        public static void WriteFile()
        {
            using (StreamWriter writer = new StreamWriter(@"records.txt"))
            {
                foreach (Car car in carList)
                {
                    writer.WriteLine(car.make + "|" + car.model + "|" + car.year + "|" + car.vin);
                }
            }
        }

        public static void ReadFile()
        {
            if (!File.Exists(@"records.txt"))
            {
                File.Create(@"records.txt");
                return;
            }

            using (StreamReader reader = new StreamReader(@"records.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string fileLine = reader.ReadLine();

                    if (fileLine != null)
                    {
                        string[] parts = fileLine.Split('|');
                        if (int.TryParse(parts[2], out int partsTwo))
                        {
                            Car car = new Car(parts[0], parts[1], partsTwo, parts[3]);
                            carList.Add(car);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }                         
                    }
                }
            }
        }
    }
}