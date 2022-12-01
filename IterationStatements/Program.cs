using System.Net.Http.Headers;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void printNegative(int num1, int num2)
        {

            for (int i = num1; i >= num2 && i <= num1; i--)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void skipNumbers(int num1, int num2)
        {
            for (int i = num1; i >= num1 && i <=num2; i++)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }
        
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        static void checkEquality(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal!");
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
            }
        }

        //Write a method to check whether a given number is even or odd
        static void checkForOdd(int num1)
        {
            int remainder = num1 % 2;
            if (remainder == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
            
        }

        //Write a method to check whether a given number is positive or negative
        static void isPositive(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine("It is positive!");
            }
            else if (num1 < 0)
            {
                Console.WriteLine("It is negative!");
            }
            else
            {
                Console.WriteLine("It is neither positive nor negative");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        static void vote(string age)
        {
            int a;
            bool car;
            car = int.TryParse(age, out a);
            if (a >= 18)
            {
                Console.WriteLine($"It is {car}, they can vote!");
            }
            else
            {
                car = false;
                Console.WriteLine($"That is {car}, they can't vote yet.");
            }

        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static void range(int num1)
        {
            if (num1 >= -10 && num1<= 10)
            {
                Console.WriteLine($"The number {num1} is in range!");
            }
            else
            {
                Console.WriteLine($"The number {num1} is out of range.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void multiplicationTable(int num1)
        {
            for (int i = 1; i <= 12; i++)
            {
                int product = num1 * i;
                Console.WriteLine(product);
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            // Method to print to console numbers 1000 thorugh -1000
            Console.WriteLine("Enter your first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int b = int.Parse(Console.ReadLine());
            Program.printNegative(a, b);

            //Method to print console numbers 3 thorugh 999 by 3 each time 
            Console.WriteLine("Enter first number");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int d = int.Parse(Console.ReadLine());
            Program.skipNumbers(c, d);

            // Method to accept to integers as parameters and check if they are equal
            Console.WriteLine("Enter first number");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int f = int.Parse(Console.ReadLine());
            Program.checkEquality(e, f);
            
            // Method to check whether a number is even or odd
            Console.WriteLine("Enter a number to find out if it is even or odd");
            int g = int.Parse(Console.ReadLine());
            Program.checkForOdd(g);
            
            // Method to check if a number is positive or negative
            Console.WriteLine("Enter a number to see if it is positive or negative");
            int h = int.Parse(Console.ReadLine());
            Program.isPositive(h);
            
            // Method to read age of a candidate and determine if they can vote 
            Console.WriteLine("Enter an age of someone that you think is allowed to vote");
            string age = Console.ReadLine();
            Program.vote(age);
            
            // Method to check if an integer from the user is in the range of -10 to 10
            Console.WriteLine("Enter a number to see if it is in the range or not");
            int i = int.Parse(Console.ReadLine());
            Program.range(i);
            
            // Method to display multiplication table (from 1 to 12) of a given integer 
            Console.WriteLine("Enter an integer");
            int j = int.Parse(Console.ReadLine());
            Program.multiplicationTable(j);
        }
    }
}

