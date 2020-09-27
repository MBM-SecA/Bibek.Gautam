using System;
using System.Net.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main()
        {
           // Making  Breakfast
            //Make tea
            //

        
        HttpClient client = new HttpClient();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        
        var google = client.GetStringAsync("www.google.com").Result;
        var microsoft = client.GetStringAsync("www.microsoft.com").Result;
        var facebook = client.GetStringAsync("www.facebook.com").Result;
        var yahoo = client.GetStringAsync("www.yahoo.com").Result;

        Console.WriteLine($"it took {stopwatch.ElapsedMilliseconds} ms");

        stopwatch.Restart();

        var g = await client.GetStringAsync("www.google.com");
        var m = await client.GetStringAsync("www.microsoft.com");
        var f = await client.GetStringAsync("www.facebook.com");
        var y = await client.GetStringAsync("www.yahoo.com");



        }
    }
}
