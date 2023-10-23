namespace Interfaces_and_ICromparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal> { new Dog(), new Cat() };

            animals.ForEach(animal => { animal.Talk(); });
        }
    }
}