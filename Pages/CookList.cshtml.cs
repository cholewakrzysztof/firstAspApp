using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPizza.Services;
using RazorPagesPizza.Models;

namespace MyApp.Namespace
{
    public class CookListModel : PageModel
    {
        public List<Cook> Cooks {get;}
        public void OnGet()
        {
        }

        public CookListModel()
        {
            Cooks = CookService.GetAll();
        }
    }
}
