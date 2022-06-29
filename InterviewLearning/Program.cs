using InterviewLearning.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========DEMO==========================");

            Console.WriteLine("1. Static");

            Panda panda1 = new Panda("Panda 1");
            Panda panda2 = new Panda("Panda 2");

            Console.WriteLine(panda1.Name);
            Console.WriteLine(panda2.Name);

            Console.WriteLine($"Population {Panda.Population}");
        }
    }
}
