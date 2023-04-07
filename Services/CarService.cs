using RazorPagesPizza.Models;
using RazorPagesPizza.Models.CarPart;
using System.Linq;

namespace RazorPagesPizza.Services{
    public static class CarService
    {
        private static List<CarMark> Marks;
        private static CarMark DefaultMark = new CarMark();
        private static Car DefaultCar = new Car();

        static CarService()
        {
            Marks = new List<CarMark>();

            //Add 2 new mark to list
            Marks.Add(new CarMark{Name="VolksWagen", Models = new List<Car>()});
            Marks[0].Models = new List<Car>();
            Marks.Add(new CarMark{Name="Audi", Models = new List<Car>()});
            Marks[1].Models = new List<Car>();

            //Default engine and break
            Engine engine = new Engine{HorsePower = 110, Capacity = 1.9, CatalogNumber = "AKL-567-FJ"};
            Brake brake = new Brake{Mark = "Brembo",Model = "Spider", CatalogNumber = "SZ-AFG-6777"};

            //Add 3 cars to VolksWagen
            Marks[0].Models.Add(new Car { Model = "Bora", Engine = engine, Brake = brake});
            Marks[0].Models.Add(new Car { Model = "Golf", Engine = engine, Brake = brake});
            Marks[0].Models.Add(new Car { Model = "Passat", Engine = engine, Brake = brake});
        }

        public static List<CarMark> GetAllMarks() => Marks;

        public static List<Car> GetAllCars(string MarkName)
        {
            foreach (CarMark Mark in Marks.DefaultIfEmpty<CarMark>(DefaultMark))
            {
                if(Mark.Name == MarkName)
                    return Mark.Models;
            }
            return DefaultMark.Models;
        }

        public static Car GetCar(string MarkName, string Model){
            foreach (CarMark Mark in Marks.DefaultIfEmpty<CarMark>(DefaultMark))
            {
                if(Mark.Name == MarkName)
                {
                    foreach (var car in Mark.Models)
                    {
                        if(car.Model==Model)
                            return car;
                    }
                }
            }
            return DefaultCar;
        }
    }
}
