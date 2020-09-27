using System;
using System.Linq;
public class ComplexType{
    public void LearnLINQ(){
        var countries = Country.GetCountries();

            var asianCountries = from country in countries where country.Continent == "Asia" select country;

            //add 20 countries
            // lisst countries in Europe thwt have population less than 100k

            var euroNations = from country in countries where country.Continent == "Europe" && country.Population < 100000 select country;

            Console.WriteLine("European nations with population less than 100k: ");


            // foreach (var country in euroNations)
            // {
            //     Console.WriteLine(country.Name);
            // }

            //list countries in Asia which are not ever invaded
            var asianNations = from country in countries where country.Continent == "Asia" && country.IndependenceDay == default select country;

            // Console.WriteLine("Asian countries that have never been invaded: ");

            // // foreach (var country in asianNations)
            // // {
            // //     Console.WriteLine(country.Name);
            // // }


            

    }
}