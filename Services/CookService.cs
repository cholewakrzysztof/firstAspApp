using RazorPagesPizza.Models;
using System.Linq;

namespace RazorPagesPizza.Services{
    public static class CookService
    {
        static List<Cook> Cooks {get;}
        static int nextId = 1;
        static private Cook DefaultCook = new Cook();

        static CookService(){
            Cooks = new List<Cook>();
            Cooks.Add(new Cook(1,"Krzysztof","Cholewa",2555.45));
        }
        public static List<Cook> GetAll() => Cooks;

        public static Cook Get(string name) 
        {
            foreach (var Cook in Cooks.DefaultIfEmpty<Cook>(DefaultCook))
            {
                if(Cook.Name == name)
                    return Cook;
            }
            return DefaultCook;
        }

        public static void Add(Cook Cook)
    {
        Cook.Id = nextId++;
        Cooks.Add(Cook);
    }
    }
}
