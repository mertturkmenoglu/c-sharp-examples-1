using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Basic control statements in c-sharp

namespace Control_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int var = Convert.ToInt32(Console.ReadLine());

            if (var == 10)
            {
                Console.WriteLine("Your Number is 10");
            }
            else if (var == 5)
            {
                Console.WriteLine("Your Number is 5");
            }
            else
            {
                Console.WriteLine("I dont know");
            }

            switch (var)
            {
                case 5: Console.WriteLine("It is 5"); break;
                case 10: Console.WriteLine("It is 10"); break;
                default: Console.WriteLine("Not 5 or 10"); break;
            }

            for (int j = 1; j <= 10; j++)
            {
                if (j == 3)
                {
                    continue;
                }
                Console.WriteLine(j);
            }

            while (var >= 0)
            {
                Console.WriteLine("Not yet");
                var--;
            }
            Console.WriteLine("Press Any Key to Exit");
            Console.ReadKey();
        }
    }
}
