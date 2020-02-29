using System;

namespace MethodsBriannaPereira
{
    class Program
    {
        static void Mymessage(int operations)
        {
            try
            {
                Console.WriteLine("Brianna Pereira");

                Random r = new Random();

                int Num1 = r.Next(6);
                int Num2 = r.Next(3);

                int addition = Num1 + Num2;
                int subtraction = Num1 - Num2;
                int multiplication = Num1 * Num2;
                int division = Num1 / Num2;
 
                string add = "The sum of "+ Num1 + " and " + Num2 +" is: " + addition;
                string sub = "The difference of "+ Num1 + " and " + Num2 +" is: " + subtraction;
                string mul = "The multiple of "+ Num1 + " and " + Num2 +" is: " + multiplication;
                string div = "The quotient of "+ Num1 + " and " + Num2 + " is: " + division;

                if(operations == 0)
                {
                    Console.WriteLine(add);
                }
                else if(operations == 1)
                {
                    Console.WriteLine(sub);
                }
                else if(operations == 2)
                {
                    Console.WriteLine(mul);
                }
                else if(operations == 3)
                {
                    Console.WriteLine(div);
                }
                else
                {
                    Console.WriteLine("Unknown flag: The operation's parameter is betwwen 0 and 3 only");
                }

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error Message: " + ex);
            }

        }
        static void Main(string[] args)
        {

            Mymessage(3);
        }
    }
}
