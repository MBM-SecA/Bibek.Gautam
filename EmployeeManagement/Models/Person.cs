using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public  int Id { get; set; }

    [Required]
    [Display(Name ="First Name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Please Enter Last Name"), Display(Name ="Last Name")]
    public string Surname { get; set; }
    public string Address { get; set; }
    public char? Gender { get; set; } = 'M'; //default value for property
    public double? Salary { get; set; }

    public static List<Person> GetDetails()
    {
        //object initializer syntax
        Person emp1 = new Person() { Id = 1, FirstName = "Bibek", Surname = "Gautam", Address = "Nijgadh", Salary = 200 };
        Person emp2 = new Person() { Id = 2, FirstName = "Bikrant", Surname = "Gautam", Address = "Nijgadh", Salary = 200 };
        Person emp3 = new Person() { Id = 3, FirstName = "Saksham", Surname = "Lamichhane", Address = "Nijgadh", Salary = 200 };
        Person emp4 = new Person() { Id = 4, FirstName = "Aayush", Surname = "Sharma", Address = "Hetauda", Salary = 200 };
        Person emp5 = new Person() {Id = 5, FirstName = "Safal", Surname = "Gautam", Address = "Nijgadh", Salary = 200 };
        Person emp6 = new Person() { Id = 6, FirstName = "Uzzwal", Surname = "Gautam", Address = "Nijgadh", Salary = 200 };

        List<Person> employees = new List<Person>() { emp1, emp2, emp3, emp4, emp5, emp6 };

        return (employees);
    }
}

