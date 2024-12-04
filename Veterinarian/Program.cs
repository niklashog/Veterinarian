namespace Veterinarian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>
            {
                new Animal { Name = "Shadow", Age = 5, NumberOfLegs = 4, Species = "Cat", IsVaccinated = true },
                new Animal { Name = "Bella", Age = 3, NumberOfLegs = 4, Species = "Dog", IsVaccinated = true },
                new Animal { Name = "Max", Age = 2, NumberOfLegs = 4, Species = "Rabbit", IsVaccinated = false },
                new Animal { Name = "Charlie", Age = 4, NumberOfLegs = 4, Species = "Dog", IsVaccinated = true },
                new Animal { Name = "Milo", Age = 1, NumberOfLegs = 4, Species = "Cat", IsVaccinated = false },
                new Animal { Name = "Daisy", Age = 6, NumberOfLegs = 4, Species = "Rabbit", IsVaccinated = true },
                new Animal { Name = "Lucy", Age = 3, NumberOfLegs = 4, Species = "Dog", IsVaccinated = false },
                new Animal { Name = "Luna", Age = 2, NumberOfLegs = 4, Species = "Cat", IsVaccinated = true },
                new Animal { Name = "Rocky", Age = 7, NumberOfLegs = 4, Species = "Dog", IsVaccinated = false },
                new Animal { Name = "Oreo", Age = 2, NumberOfLegs = 4, Species = "Rabbit", IsVaccinated = false },
                new Animal { Name = "Simba", Age = 4, NumberOfLegs = 4, Species = "Cat", IsVaccinated = true }
            };


            var numberOfDogs = animals
                .Count(a => a.Species == "Dog");

            Console.WriteLine(numberOfDogs);


            var oldestAnimal = animals
                .OrderByDescending(a => a.Age)
                .First(a => a.Age > 0);

            Console.WriteLine(oldestAnimal.Age);


            var vaccinatedAnimals = animals
                .Where(a => a.IsVaccinated == true)
                .ToList();

            vaccinatedAnimals
                .ForEach(a => Console.WriteLine($"Is vaccinated: {a.Name}"));

            var fourLegsAndOverThreeYears = animals
                .Where(a => a.Age > 3)
                .Where(a => a.NumberOfLegs == 4)
                .ToList();

            fourLegsAndOverThreeYears
                .ForEach(a => Console.WriteLine($"Four Legs & Over 3 years of age: {a.Name}"));

            var doesShadowExist = animals
                .Any(a => a.Name == "Shadow");

            Console.WriteLine($"Shadow exists: {doesShadowExist}");
        }
    }
}
