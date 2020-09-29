using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main1()
        {
            Stopwatch stopwatch = new Stopwatch();

            // int[] numbers = { 16, 12, 5, 8, 10 };

            // //TPL -parallel Programming

            // //Sequential Programming
            // stopwatch.Start();
            // Console.WriteLine("Sequential Execution");

            // foreach (var num in numbers)
            // {
            //     var result = Factorial(num);
            //     Console.WriteLine($"{num}! = {result}");
            // }
            // Console.WriteLine($"Time taken  {stopwatch.ElapsedMilliseconds} ms");

            // //Parallel Implementation
            // stopwatch.Restart();
            // Console.WriteLine("Parallel Execution");
            // Parallel.ForEach(numbers, num =>
            // {

            //     var result = Factorial(num);
            //     Console.WriteLine($"T{num}! = {result}");
            // });
            // Console.WriteLine($"Time taken  {stopwatch.ElapsedMilliseconds} ms");


            //Async programming

            //Sequential execution
            // stopwatch.Start();
            // TurnOnBurner();
            // PlaceKettleonBurner();
            // Pourwater();
            // Boil("Water");
            // GrindMasala();
            // PutSugarAndMasala();
            // AddMilk();
            // Boil("Milk");
            // TurnOnBurner();
            // PlacePanOnBurner();
            // CrackAndWhiskEgg();
            // Fry();
            // Serve();

            // Console.WriteLine($"Time taken  {stopwatch.ElapsedMilliseconds} ms");





        }

        static async Task Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            //parallel version: Expected time 63 sec
            await TurnOnBurner();
            await TurnOnBurner();
            await PlaceKettleonBurner();
            await Pourwater();
            await Boil("Water");
            await GrindMasala();
            await PutSugarAndMasala();
            await AddMilk();
            await Boil("Milk");
            await TurnOnBurner();
            await PlacePanOnBurner();
            await CrackAndWhiskEgg();
            await Fry();
            await Serve();

            Console.WriteLine($"Time taken  {stopwatch.ElapsedMilliseconds} ms");
        }



        private static Task Serve()
        {
            Console.WriteLine("Serving");
            Task.Delay(3000);
            return Task.CompletedTask;
        }

        private static Task Fry()
        {
            Console.WriteLine("Frying");
            Task.Delay(6000);
            return Task.CompletedTask;

        }

        private static Task CrackAndWhiskEgg()
        {
            Console.WriteLine("Cracking and Mixing eggs.");
            Task.Delay(10000);
            return Task.CompletedTask;

        }

        private static Task PlacePanOnBurner()
        {
            Console.WriteLine("placing pan on burner.");
            Task.Delay(3000);
            return Task.CompletedTask;

        }

        private static Task PutSugarAndMasala()
        {
            Console.WriteLine("Adding Sugar and Masala");
            Task.Delay(5000);
            return Task.CompletedTask;

        }

        private static Task AddMilk()
        {
            Console.WriteLine("Adding Milk");
            Task.Delay(3000);
            return Task.CompletedTask;

        }

        private static Task GrindMasala()
        {
            Console.WriteLine("Grinding Masala");
            Task.Delay(10000);
            return Task.CompletedTask;

        }

        private static Task Boil(string v)
        {
            Console.WriteLine($"Boiling {v}.");
            Task.Delay(7000);
            return Task.CompletedTask;

        }

        private static Task Pourwater()
        {
            Console.WriteLine("Pouring Water");
            Task.Delay(3000);
            return Task.CompletedTask;

        }

        private static Task PlaceKettleonBurner()
        {
            Console.WriteLine("Placing kettle on burner.");
            Task.Delay(2000);
            return Task.CompletedTask;

        }



        private static Task TurnOnBurner()
        {
            Console.WriteLine("Turning on Burner.");
            Task.Delay(2000);
            return Task.CompletedTask;

        }

        //Sequential


        //         private static void Serve()
        //         {
        //            Console.WriteLine("Serving");
        //             Thread.Sleep(3000);
        //         }

        //         private static void Fry()
        //         {
        //             Console.WriteLine("Frying");
        //             Thread.Sleep(6000);
        //         }

        //         private static void CrackAndWhiskEgg()
        //         {
        //             Console.WriteLine("Cracking and Mixing eggs.");
        //             Thread.Sleep(10000);
        //         }

        //         private static void PlacePanOnBurner()
        //         {
        //             Console.WriteLine("placing pan on burner.");
        //             Thread.Sleep(3000);
        //         }

        //         private static void PutSugarAndMasala()
        //         {
        // Console.WriteLine("Adding Sugar and Masala");
        //             Thread.Sleep(5000);        
        //         }

        //         private static void AddMilk()
        //         {
        //             Console.WriteLine("Adding Milk");
        //             Thread.Sleep(3000);
        //         }

        //         private static void GrindMasala()
        //         {
        //             Console.WriteLine("Grinding Masala");
        //             Thread.Sleep(10000);
        //         }

        //         private static void Boil(string v)
        //         {
        //             Console.WriteLine($"Boiling {v}.");
        //             Thread.Sleep(7000);
        //         }

        //         private static void Pourwater()
        //         {
        //             Console.WriteLine("Pouring Water");
        //             Thread.Sleep(3000);
        //         }

        //         private static void PlaceKettleonBurner()
        //         {
        //             Console.WriteLine("Placing kettle on burner.");
        //             Thread.Sleep(2000);
        //         }



        //         private static void TurnOnBurner()
        //         {
        //             Console.WriteLine("Turning on Burner.");
        //             Thread.Sleep(2000);
        //         }



        // static long Factorial(long number)
        // {
        //     Thread.Sleep(100);
        //     return 0;

        // }
    }
}
