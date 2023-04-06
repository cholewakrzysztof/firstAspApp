using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza.Models
{
    public class Cook
    {
        public Cook(int id, string name, string surname, double salary){
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Salary = salary;
        }
        public Cook(){
            this.Id = 0;
            this.Name = "Jane";
            this.Surname = "Doe";
            this.Salary = 9999;
        }

        [Required]
        public int Id;
        public string? Name {get;set;}
        public string? Surname {get;set;}
        public double Salary {get;set;}
    }
}
public enum CookSex {Male, Female, Unknown}