using System;
using System.Collections.Generic;
using System.IO;

namespace object_oriented_fundamentals_onur
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Creator> creators = new List<Creator> { new Youtuber(), new Programmer() };

            foreach (var creator in creators)
            {
                Console.WriteLine(creator.GetType().Name);
                creator.Create();
                Console.WriteLine();
            }
            
        }
    }
}
