using System;
using System.Collections.Generic;
public class Country
{
    public string Name { get; set; }
    public string Continent { get; set; }
    public double Area { get; set; }
    public long Population { get; set; }
    public DateTime IndependenceDay { get; set; }

    public Country(string name, string continent, double area, long population, DateTime independence = default)
    {
        Name = name;
        Continent = continent;
        Area = area;
        Population = population;
        IndependenceDay = independence;
    }

    public static List<Country> GetCountries()
    {
        // Country c1 = new Country();
        // c1.Name = "Nepal";
        // c1.Continent = "Asia";
        // c1.Area = 147181.00;
        // c1.Population = 30000000;

        // countries.Add(c1);

        // Country c2 = new Country {Name = "India",  Continent = "Asia", Area = 15478521, Population = 23564125478 , IndependenceDay = 15 };

        Country c1 = new Country("Nepal", "Asia", 147181, 30000000);
        Country c2 = new Country("India", "Asia", 2356516.25, 30000000000, new DateTime (1947, 01,01));
        Country c3 = new Country("Russia", "Europe", 321456.21, 125412532);
        Country c4 = new Country("USA", "North America", 251423.32, 1425123621);
        Country c5 = new Country("Canada", "North America", 251423.32, 1425123621);
        Country c6 = new Country("Bhutan", "Asia", 251423.32, 1425123621, new DateTime (1845, 01,01));
        Country c7 = new Country("South  Africa", "Africa", 11254.23, 142512);

        Country c8 = new Country("UK", "Europe", 251423.32, 99251);
        Country c9 = new Country("Australia", "Australia", 251423.32, 1425123621);
        Country c10 = new Country("Germany", "Europe", 251423.32, 36547);
        Country c11 = new Country("Brazil", "South America", 251423.32, 1425123621);
        Country c12 = new Country("Italy", "Europe", 251423.32, 1425123621);
        Country c13 = new Country("Egypt", "Africa", 251423.32, 1425123621);
        Country c14 = new Country("Chile", "South America", 251423.32, 1425123621);
        Country c15 = new Country("Pakistan", "Asia", 251423.32, 1425123621);
        Country c16 = new Country("China", "Asia", 251423523.32, 1425123621, new DateTime (1825, 01,01));
        Country c17 = new Country("Nigeria", "Africa", 251423.32, 1425123621);
        Country c18 = new Country("Spain", "Europe", 251423.32, 78621);
        Country c19 = new Country("Japan", "Asia", 251423.32, 1425123621, new DateTime (1888, 01,01));
        Country c20 = new Country("France", "Europe", 251423.32, 1425123621);

        var countries = new List<Country> { c1, c2, c3, c4, c5, c6,  c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20 };
        return countries;

    }


}