using System;

namespace lab1ex1
{
    /*Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui paralelipiped dreptunghic, va afisa volumul lui*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va calcula volumul unui paralepiped. \n");

            Console.WriteLine("Introduceti dimensiunile laturii 1:");
            var latura1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti dimensiunile laturii 2:");
            var latura2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti dimensiunile laturii 3:");
            var latura3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Volulmul paralepipedului este: " + latura1* latura2* latura3);
          
        }

    }
}
