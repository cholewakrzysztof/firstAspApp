using System.ComponentModel.DataAnnotations;
using  RazorPagesPizza.Models.CarPart;

namespace RazorPagesPizza.Models{
    public class Car
    {
        public string? PictureSoure {get;set;}

        [Required]
        public string? Model {get;set;}
        public Brake? Brake {get;set;}
        public Engine? Engine {get;set;}
        
    }
    public enum Paliwo{benzyna,diesel}
}
