using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

namespace MyApp.Namespace
{
    public class CookModel : PageModel
    {
        public Cook cook;
        public void OnGet(string name)
        {
            cook = CookService.Get(name);
        }
        public CookModel()
        {
            cook = CookService.Get("Jane");
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
