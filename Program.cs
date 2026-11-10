using System.Security.Principal;

namespace Lab_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic
            //.1
             Console.WriteLine("enter a number");
             int number = int.Parse(Console.ReadLine());
             Console.WriteLine($"You entered: {number}"); 

            //.2
            double number1 = 0.3;
            double number2 = 0.2;
            double result = number1 - number2;
            Console.WriteLine(result); 
            //instead of printing 0.1, it prints 0.09999999999999998

            //.3
            int a = 10;
            int b = a;
            Console.WriteLine($"a = {a}, b = {b}");
            b = 20;
            Console.WriteLine($"a = {a}, b = {b}"); 
            //changing b does not affect a because they are value types and stored in different memory locations

            //.4
             Console.WriteLine("enter the principle amount");
            decimal principle = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the interest rate %");
            decimal interestRate = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the time in years");
            decimal time=decimal.Parse(Console.ReadLine());
            decimal interest = (principle * interestRate * time)/100m;
            Console.WriteLine($"The interest is: {interest}");
            Console.WriteLine($"Total Amount (Principal + Interest): {principle + interest}"); 

            //.5
             Console.WriteLine("enter the temprature in Celsius");
             decimal tem = decimal.Parse(Console.ReadLine());
             string result1 = tem < 10 ? "just cold"
                            : tem > 30 ?"just hot"
                            : "just good";
             Console.WriteLine(result1); 

            //.6
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num %3 == 0 && num % 4 == 0)
            {
                Console.WriteLine("Yes,The number is divided by both 3 and 4");
            }
            else
            {
                Console.WriteLine("No,The number can not divided by either 3 or 4");
            }

            //.7
             Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            int num3 = int.Parse(Console.ReadLine());
            int max = Math.Max(num1, Math.Max(num2, num3));
            int min = Math.Min(num1, Math.Min(num2, num3));
            Console.WriteLine($"The maximum number is: {max}");
            Console.WriteLine($"The minimum number is: {min}"); 

            //.8
            /  Console.WriteLine("Month number :");
              int month = int.Parse(Console.ReadLine());
              int days = 0;
              switch (month) {
                  case 1:
                  case 3:
                  case 5:
                  case 7:
                  case 8:
                  case 10:
                  case 12:
                      days = 31;
                      break;
                  case 4:
                  case 6:
                  case 9:
                  case 11:
                      days = 30;
                      break;
                  case 2:
                      days = 28;
                      break;
                  default:
                      Console.WriteLine("Invalid month number");
                      return;// stops prgrame and exit never goes to the next line
              }
                  Console.WriteLine($"The number of days in month {month} is: {days}"); 
            #endregion

            #region Loops & Numbers
            //.9
             Console.WriteLine("enter a number");
             int number3 = int.Parse(Console.ReadLine());
             for (int i = 1; i <= number3; i++)
             {
                 Console.Write(i);
                 if (i < number3) { 
                 Console.Write(", ");
                 }
             }
             Console.WriteLine(); 

            //.10
             Console.WriteLine("enter a number");
             int num11 = int.Parse(Console.ReadLine());
             for(int i=1; i <= 12; i++)
             {
                 Console.Write(i * num11);
                 if (i < 12)
                 {
                     Console.Write(", ");
                 }
             } 

            //.11
             Console.WriteLine("please enter a number");
             int x = int.Parse(Console.ReadLine());
             for (int i = 1; i <= x; i++) { 
                 if(i % 2 == 0)
                 {
                     Console.Write(i);
                     if (i < x)
                     {
                         Console.Write(" ");
                     }
                 }
             }

            //.12
              Console.WriteLine("please enter first number");
              double firstNumber = double.Parse(Console.ReadLine());
              Console.WriteLine("please enter second number");
              double secondNumber = double.Parse(Console.ReadLine());
              Double power = Math.Pow(firstNumber, secondNumber);
              Console.WriteLine($"{firstNumber} raised to the power of {secondNumber} is: {power}"); */

            //.13
               Console.WriteLine("please enter a number");
               int numberr = int.Parse(Console.ReadLine());
               int reversed = 0;
               while (numberr != 0)
               {
                   int digit = numberr % 10;
                   reversed = reversed * 10 + digit;
                   numberr /= 10;
               }
               Console.WriteLine($"The reversed number is: {reversed}");
            //explaining the logic:
            //when we take the last digit of the number using modulus operator, we can add it to the reversed number by
            //multiplying the reversed number by 10 and adding the digit.
            //Then we remove the last digit from the original number by dividing it by 10.
            //We repeat this process until the original number becomes 0.

            //.15
            Console.WriteLine("enter point1 coordinates: ");
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter point2 coordinates: ");
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter point3 coordinates: ");
            Console.Write("x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3: ");
            double y3 = double.Parse(Console.ReadLine());

            double area = x1*(y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

            if(Math.Abs(area) < 1e-10)
            {
                Console.WriteLine("The points LIE on a single straight line");
            }
            else
            {
                Console.WriteLine("The points do NOT lie on a single straight line");
            }   
            #endregion
        }
    }
}
