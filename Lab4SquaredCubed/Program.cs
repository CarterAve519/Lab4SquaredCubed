using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4SquaredCubed
{
    class Program
    {
        static void Main(string[] args)
        {
            //User starts
            Console.WriteLine("Learn your squares and cubes!");
            //Gives extra line between phrases
            Console.WriteLine();

            //start loop
            string total;

            do
            {

                //Prompt user to enter number
                Console.WriteLine("Enter an integer");

                //Declare the variable
                //Converting user input from string to integer
                //int is integer, defining variable d, = initializing variables d]
                //whenever I use d I'm calling the Convert method
                int d = Convert.ToInt32(Console.ReadLine());

                //How to get number to display the range
                //g is input, the start of my range
                //for loop interation/repeition (g is a constant variable) d is calling some method
                for (int g = 1; g <= d; g++)
                {
                    //print number range
                    Console.Write(g + "\t");

                    //display range of numbers squared
                    //\t = gives space between the columns
                    Console.Write(g * g + "\t");

                    //display range of number cubed
                    //"\t = gives space between the colmns"
                    Console.WriteLine(g * g * g + "\t");
                }
                //Complete while loop
                Console.WriteLine("Continue? (y/n)");
                total = Console.ReadLine();
            }
            //do "code" while total = y (yes)
            while (total == "y");
        }
    }
}
