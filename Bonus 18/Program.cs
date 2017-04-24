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
            numOfCars = int.Parse(Console.ReadLine());

            int[] newCars = new int[numOfCars];



            for (int i = 1; i <= numOfCars; i++)
            {
                Console.WriteLine("Enter Car #{0} Make: ", i);
                Make = Console.ReadLine();
                Console.WriteLine("Enter Car #{0} Model: ", i);
                Model = Console.ReadLine();
                Console.WriteLine("Enter Car #{0} Year: ", i);
                Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Car #{0} Price: ", i);
                Price = decimal.Parse(Console.ReadLine());

                Car c = new Car(Make, Model, Year, Price);

                Console.WriteLine("Current Inventory:");
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t", c.Make, c.Model, c.Year, c.Price);
            }          
        }
    }
}
