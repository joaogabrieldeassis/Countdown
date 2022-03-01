using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main()
        {

            Menu();
        }
        static void Menu()


        {
            Console.Clear();
            Console.WriteLine("S = segundo => 10s = 10 segundos");
            Console.WriteLine("M = minuto => 1m = minuto");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo deseja contar ?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;
            if (type == 'm')

                multiplier = 60;
            if (time == 0)

                System.Environment.Exit(0);
            PreStart(time * multiplier);



        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set....");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2000);
            Start(time);
        }
        static void Start(int time)
        {

            int i = 0;
            while (i != time)
            {
                Console.Clear();
                i++;
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stop Finalizado");
            Thread.Sleep(2000);
            Menu();
        }
    }
}