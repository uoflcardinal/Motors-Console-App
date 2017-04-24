using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_18
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfCars;
            string Make;
            string Model;
            int Year;
            decimal Price;


            Console.WriteLine("Welcome to the Grand Circus Motors admin console!\n\n");

            Console.Write("How many cars are you entering: ");
            numOfCars = Validator.GetValidInteger();

            Car[] newCars = new Car[numOfCars];

            for (int i = 0; i <= numOfCars - 1; i++)
            {
                Console.WriteLine("Enter Car #{0} Make: ", i + 1);
                Make = Validator.GetValidString();
                Console.WriteLine("Enter Car #{0} Model: ", i + 1);
                Model = Validator.GetValidString();
                Console.WriteLine("Enter Car #{0} Year: ", i + 1);
                Year = Validator.GetValidInteger();
                Console.WriteLine("Enter Car #{0} Price: ", i + 1);
                Price = Validator.GetValidDecimal();

                Car c = new Car(Make, Model, Year, Price);

                newCars[i] = c;
            }

            Console.WriteLine("Current Inventory:");

            for (int i = 0; i <= numOfCars - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}${3}", newCars[i].Make.PadRight(10), newCars[i].Model.PadRight(10), newCars[i].Year.ToString().PadRight(10), newCars[i].Price);
            }
        }
    }
}
