using System;
using System.Linq;

namespace Proj02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string Name = AskName();
                int Age = AskAge();
                Console.WriteLine("Your Name is " +Name+ " and you are " +Age+ " years old!");
                Console.ReadLine();
            }
        }

        static int AskAge()
        {
            Boolean AgeCheck = true;
            int Age = 0;
            while (AgeCheck)
            {
                Console.Write("Type Your Age: ");
                string AgeInput = Console.ReadLine();
                if (AgeInput.All(char.IsDigit) && (Int32.TryParse(AgeInput, out Age)))
                {
                    AgeCheck = false;
                }
                else
                    Console.WriteLine("Try Again");
            }
            return Age;
        }
        
        static string AskName()
        {
            Boolean NameCheck = true;
            string NameInput = "";
            while (NameCheck)
            {
                Console.Write("Type Your First Name: ");
                NameInput = Console.ReadLine();
                if (NameInput.All(char.IsLetter))
                {
                    NameCheck = false;
                }
                else
                    Console.WriteLine("Try Again");
            }
            return NameInput;
        }

    }
    }