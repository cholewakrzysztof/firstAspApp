using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

namespace MyApp.Namespace
{
    public class CookModel : PageModel
    {
        public Cook? cook;
        public void OnGet()
        {
            cook = CookService.Get(0);
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            CookService.Add(NewCook);
            return RedirectToAction("Get");
        }

        [BindProperty]
        public Cook NewCook { get; set; } = new();
    }
}
