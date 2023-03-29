using RazorPagesPizza.Models;

namespace RazorPagesPizza.Services{
    public static class CookService
    {
        static List<Cook> Cooks {get;}
        static int nextId = 1;

        static CookService()
        {
            Cooks = new List<Cook>(){new Cook{Id = 0,Name="Krzysztof",Surname = "Cholewa", Salary = 2500}};
        }

        public static List<Cook> GetAll() => Cooks;

        public static Cook? Get(string name) => Cooks.FirstOrDefault(c => c.Name == name);

        public static void Add(Cook Cook)
    {
        Cook.Id = nextId++;
        Cooks.Add(Cook);
    }
    }
}
