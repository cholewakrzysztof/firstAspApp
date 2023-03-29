using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza.Models
{
    public class Cook
    {
        public int Id;

        [Required]
        public string? Name {get;set;}
        public string? Surname {get;set;}
        public double Salary {get;set;}
    }
}
public enum CookSex {Male, Female}