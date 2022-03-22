using System;

namespace Main
{
    class Program {
        public static void Main(string[] args) {
            var totalSecs = 0;

            for (int i = 0; i < int.Parse(args[0]); i++)
            {
                Console.WriteLine("Min");
                var mins = int.Parse(Console.ReadLine());
                Console.WriteLine("Secs");
                var secs = int.Parse(Console.ReadLine());
            
                totalSecs += mins*60 + secs;
            }

            totalSecs /= int.Parse(args[0]);

            var minsAO = Math.Floor(((double) totalSecs)/60);
            var secsAO = totalSecs % 60;

            Console.WriteLine("{0}m{1}s", minsAO, secsAO);
        }
    }
}