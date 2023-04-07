using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

namespace MyApp.Namespace
{
    public class CarModel : PageModel
    {
        public Car car;
        public void OnGet(string name, string model)
        {
            car = CarService.GetCar(name,model);
        }
        public CarModel(){
            car = CarService.GetCar("VolksWagen","Bora");
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToAction("Get");
        }
    }
}
