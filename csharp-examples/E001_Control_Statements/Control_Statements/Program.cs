using System;

//Basic control statements in c-sharp
namespace Control_Statements
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number == 10)
            {
                Console.WriteLine("Your Number is 10");
            }
            else if (number == 5)
            {
                Console.WriteLine("Your Number is 5");
            }
            else
            {
                Console.WriteLine("I dont know");
            }

            switch (number)
            {
                case 5: Console.WriteLine("It is 5"); break;
                case 10: Console.WriteLine("It is 10"); break;
                default: Console.WriteLine("Not 5 or 10"); break;
            }

            for (var j = 1; j <= 10; j++)
            {
                if (j == 3)
                {
                    continue;
                }
                
                Console.WriteLine(j);
            }

            while (number >= 0)
            {
                Console.WriteLine("Not yet");
                number--;
            }
            
            Console.WriteLine("Press Any Key to Exit");
            Console.ReadKey();
        }
    }
}
