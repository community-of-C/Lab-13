using System.Security.Principal;

namespace Lab_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic
            //.1
            /* Console.WriteLine("enter a number");
             int number = int.Parse(Console.ReadLine());
             Console.WriteLine($"You entered: {number}"); */

            //.2
            /*double number1 = 0.3;
            double number2 = 0.2;
            double result = number1 - number2;
            Console.WriteLine(result); */
            //instead of printing 0.1, it prints 0.09999999999999998

            //.3
            /*int a = 10;
            int b = a;
            Console.WriteLine($"a = {a}, b = {b}");
            b = 20;
            Console.WriteLine($"a = {a}, b = {b}"); */
            //changing b does not affect a because they are value types and stored in different memory locations

            //.4
            /* Console.WriteLine("enter the principle amount");
            decimal principle = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the interest rate %");
            decimal interestRate = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the time in years");
            decimal time=decimal.Parse(Console.ReadLine());
            decimal interest = (principle * interestRate * time)/100m;
            Console.WriteLine($"The interest is: {interest}");
            Console.WriteLine($"Total Amount (Principal + Interest): {principle + interest}"); */

            //.5
            /* Console.WriteLine("enter the temprature in Celsius");
             decimal tem = decimal.Parse(Console.ReadLine());
             string result = tem < 10 ? "just cold"
                            : tem > 30 ?"just hot"
                            : "just good";
             Console.WriteLine(result); */

            //.6
            /*Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num %3 == 0 && num % 4 == 0)
            {
                Console.WriteLine("Yes,The number is divided by both 3 and 4");
            }
            else
            {
                Console.WriteLine("No,The number can not divided by either 3 or 4");
            }*/

            //.7

            #endregion
        }
    }
}
