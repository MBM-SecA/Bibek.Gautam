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



            var countries = Country.GetCountries();

            var asianCountries = from country in countries where country.Continent == "Asia" select country;

            //add 20 countries
            // lisst countries in Europe thwt have population less than 100k

            var euroNations = from country in countries where country.Continent == "Europe" && country.Population < 100000 select country;

            Console.WriteLine("European nations with population less than 100k: ");


            foreach (var country in euroNations)
            {
                Console.WriteLine(country.Name);
            }

            //list countries in Asia which are not ever invaded
            var asianNations = from country in countries where country.Continent == "Asia" && country.IndependenceDay == default select country;

            Console.WriteLine("Asian countries that have never been invaded: ");

            foreach (var country in asianNations)
            {
                Console.WriteLine(country.Name);
            }







        }
    }
}
