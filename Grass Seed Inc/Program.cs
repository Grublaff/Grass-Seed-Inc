using System;
using System.Collections.Generic;
using System.Linq;

namespace Grass_Seed_Inc{
    class Program{
        static void Main(){
            double cost = Double.Parse(Console.ReadLine());
            double lawnToSow = Double.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < lawnToSow; i++){
                String[] split = Console.ReadLine().Split(" ");
                total += Double.Parse(split[0]) * Double.Parse(split[1]) * cost;
            }
            Console.WriteLine(total);
        }
    }
}
