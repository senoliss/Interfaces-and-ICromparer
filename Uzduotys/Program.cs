namespace Uzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<Car> cars = new List<Car>
            //{

            //    new Car
            //    {
            //        Model = "Fordux",
            //        Fuel = 15,
            //    },
            //    new Car
            //    {
            //        Model = "Volvo",
            //        Fuel = 40
            //    },
            //    new Car
            //    {
            //        Model = "BMW",
            //        Fuel = -15
            //    },
            //    new Car
            //    {
            //        Model = "VW",
            //        Fuel = 0
            //    }
            //};

            //foreach (Car car in cars)
            //{
            //    car.Drive(25);
            //}
            //Console.WriteLine("----------------");
            //foreach (Car car in cars)
            //{
            //    car.Refuel(25);
            //}

            var bmw = new BmwCar(true, "Bmw", 50);
            var audi = new AudiCar(false, "Audi", 100);

            bmw.Drive(25);
            bmw.Refuel(90);

            audi.Drive(80);
            audi.Refuel(50);

            Console.WriteLine(bmw.Model + " has four wheel drive? " + (bmw.IsXDrive ? "Yes" : "No"));
            Console.WriteLine(audi.Model + " has four wheel drive? " + (audi.IsQuattro ? "Yes" : "No"));

            List<BmwCar> list = new List<BmwCar>()
            {
                new BmwCar
                {
                    IsXDrive = false, 
                    Model = "X1", 
                    Fuel = 60
                },
                new BmwCar
                {
                    IsXDrive = false, 
                    Model = "X2", 
                    Fuel = 35
                },
                new BmwCar
                {
                    IsXDrive = true, 
                    Model = "X3", 
                    Fuel = 50
                },
                new BmwCar
                {
                    IsXDrive = false, 
                    Model = "X4", 
                    Fuel = 10
                },
                new BmwCar
                {
                    IsXDrive = true, 
                    Model = "X5", 
                    Fuel = 80
                },
                new BmwCar
                {
                    IsXDrive = true, 
                    Model = "X6", 
                    Fuel = 70
                },

            };

            var carComparer = new BmwCarComparer();

            Console.WriteLine("=====Unsorted w/o comparer=====");
            foreach (BmwCar car in list)
            {
                Console.WriteLine(car.Model);
            }

            list.Sort(carComparer);
            
            Console.WriteLine("=======Sorted w comparer=======");
            foreach (BmwCar car in list) 
            {
                Console.WriteLine(car.Model);
            }

        }
    }
}