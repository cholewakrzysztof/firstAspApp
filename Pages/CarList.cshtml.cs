using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPizza.Services;
using RazorPagesPizza.Models;


namespace MyApp.Namespace
{
    public class CarListModel : PageModel
    {
        public List<CarMark> Marks;
        public void OnGet()
        {
        }

        public CarListModel(){
            Marks = CarService.GetAllMarks();
        }
    }
}
