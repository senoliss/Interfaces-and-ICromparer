namespace Uzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {

                new Car
                {
                    Model = "Fordux",
                    Fuel = 15
                },
                new Car
                {
                    Model = "Volvo",
                    Fuel = 40
                },
                new Car
                {
                    Model = "BMW",
                    Fuel = -15
                },
                new Car
                {
                    Model = "VW",
                    Fuel = 0
                }
            };

            foreach (Car car in cars)
            {
                car.Drive(25);
            }
            Console.WriteLine("----------------");
            foreach (Car car in cars)
            {
                car.Refuel(25);
            }
        }
    }
}