using System;
using System.Dynamic;

namespace repotestfile
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var rand = new Random();
           int random = rand.Next(100, 200);
            bool game = true;
            while (game)
            {
            Console.WriteLine("Guess a number between 100 and 200");
            string guess = Console.ReadLine();
            int result = Int32.Parse(guess);

            if (result < random)
            {
                Console.WriteLine("the result number is too low");
                    game = true;
                  
            }
            else if(result > random)
                {
                Console.WriteLine("the result is too high");
                    game = true;
                  
                }
            else
            {
                Console.WriteLine($"your result is correct the number was{random}");
                    game = false;
            }
            }
        }
    }
}
