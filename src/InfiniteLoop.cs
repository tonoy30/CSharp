
using System;

namespace WhileLoop
{
    public class InfiniteLoop
    {
        public void Loop()
        {
            var name = "";
            while (name != "Tonoy")
            {
                Console.WriteLine("What is ur name?");
                name = Console.ReadLine();
                if (name != "Tonoy")
                {
                    Console.WriteLine("Are u forget ur name?");
                }

            }
            Console.WriteLine("Great! You remind me.");
        }
    }
}