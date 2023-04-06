using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza{
    public class Car
    {
        [Required]
        public int id_auto;
        public string marka;
        public string kolor;
        public string nr_rej;
        public int przebieg;
        public int cena_pln;
        public int cena_eu;
        public int rok_prod;
        public double pojemnnosc;
        public Paliwo paliwo;
    }
    public enum Paliwo{benzyna,diesel}
}
