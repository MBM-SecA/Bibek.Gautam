using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()
        {

            //LINQ => LAnguage Integrated Query

            int[] numbers = { 23, 24, 65, 63, 87, 95, 63, 14, 25 };

            //fetch numbers which are greater than 50

            //Using Method Syntax - lambda expression
            var numbersGreaterThan50 = numbers.Where(x => x > 50);

            //Using query syntax - query expression
            var numbersGreaterThanFifty = from num in numbers where num > 50 select num;

            

            string[] names = { "Ram", "Ed", "James", "Ronald", "RD", "Ramesh" };
            var initialR = names.Where(x => x.Length > 3 && x[0] == 'R');

            var initialr = from name in names
                           where name.Length > 3 && name.StartsWith("R")
                           select name;

            //Projections
            var result5 = numbers.Select(x => x * x);

            //var result5 = from num in numbers select num * num;

           
            //ordering the numbers in collection
            var result6 = from num in numbers
                            orderby num ascending 
                            select num;
            
            

            // var result7 = from name in names
            //                 orderby name descending
            //                 select name;

            //partitioning  
            var result8 = numbers.Skip(5).Take(5);

            //find even numbers in the collection
            var result9 = numbers.Any(x => x % 2 == 0); //return type: boolean

            //check if all the numbers are even in the collection
            var result10 = numbers.All(x => x % 2 == 0); //return type; boolean

            //check for a particular item in the  collection
            var result11 = numbers.Contains(34); //return type : boolean

            //generating data

            var result12 = Enumerable.Range(1, 1000);
            var result13 = Enumerable.Repeat("Hello World!", 10) ;

            //print
             foreach (var num in result13){
                Console.WriteLine(num);
            }


            






        }
    }
}
