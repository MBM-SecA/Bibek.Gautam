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


}

