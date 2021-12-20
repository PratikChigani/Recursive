using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Factorial through Recursion 
namespace Recursive
{
    class calculate
    {
        double result;
        public double Factorial(double n)                                                                  //Passing the number n to the Mehtod Factorial() which we have taken  
        {
            if (n==1)
            {
                return 1;                                                                         
            }
            else
            {
                result = Factorial(n - 1) * n;                                                              //Method will call itself until n becomes 1 
                return result;
            }
        }
    
        static void Main(string[] args)
        {
            calculate obj = new calculate();                                                                //Creating obj named Object of class calculate()
            Console.WriteLine("Enter a number:\n");
            double num = double.Parse(Console.ReadLine());                                                  //Taking a number of which we want Factorial From console and typecasting into Double Type
            Console.WriteLine($"The factorial of your entered number {num} is {obj.Factorial(num)}.");      //Printing value or factorial of a number
            Console.ReadKey();
        }
    }
}
