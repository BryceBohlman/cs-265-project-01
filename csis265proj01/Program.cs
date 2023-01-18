using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265week01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //  Step 1:         declare and initialize all necessary variables
            double sideLengthA = 0;
            double sideLengthB = 0;
            double sideLengthC = 0;


            //  Step 2:         prompt the user for input values 
            System.Console.Write("Enter the length for side A of a right triangle: ");
            sideLengthA = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Enter the length for side B of a right triangle: ");
            sideLengthB = Convert.ToDouble(System.Console.ReadLine());


            //  Step 3:         "do the math" (number crunching and formulas)
            sideLengthC = Math.Sqrt((sideLengthA * sideLengthA) + (sideLengthB * sideLengthB));

            //  Step 4:         display the output
            System.Console.WriteLine("The hypotenuse length is: " + sideLengthC);

            System.Console.ReadLine();
        }
    }
}
