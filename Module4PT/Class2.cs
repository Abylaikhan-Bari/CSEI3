using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Base class Animal
abstract class Animal
{
    public int ID { get; set; }
    public string Name { get; set; }
    public abstract string Type { get; }
    public abstract double CalculateFoodRequired();
}

// Derived class for Carnivorous animals
class Carnivorous : Animal
{
    public override string Type => "Carnivorous";
    public override double CalculateFoodRequired()
    {
        // Calculate food requirement logic for carnivorous animals
        return 2.0;
    }
}

// Derived class for Omnivorous animals
class Omnivorous : Animal
{
    public override string Type => "Omnivorous";
    public override double CalculateFoodRequired()
    {
        // Calculate food requirement logic for omnivorous animals
        return 1.5;
    }
}

// Derived class for Herbivorous animals
class Herbivorous : Animal
{
    public override string Type => "Herbivorous";
    public override double CalculateFoodRequired()
    {
        // Calculate food requirement logic for herbivorous animals
        return 1.0;
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Carnivorous { ID = 1, Name = "Lion" },
            new Herbivorous { ID = 2, Name = "Giraffe" },
            new Omnivorous { ID = 3, Name = "Bear" },
            new Carnivorous { ID = 4, Name = "Tiger" },
            new Herbivorous { ID = 5, Name = "Elephant" },
        };

        // Sorting animals by food required in descending order, and then by name
        var sortedAnimals = animals.OrderByDescending(a => a.CalculateFoodRequired())
                                   .ThenBy(a => a.Name)
                                   .ToList();

        // Output all animals with ID, Name, Type, and Food Required
        Console.WriteLine("All Animals:");
        foreach (var animal in sortedAnimals)
        {
            Console.WriteLine($"ID: {animal.ID}, Name: {animal.Name}, Type: {animal.Type}, Food Required: {animal.CalculateFoodRequired()}");
        }

        // Output the first 5 animal names
        Console.WriteLine("\nFirst 5 Animal Names:");
        var first5Names = sortedAnimals.Take(5).Select(a => a.Name).ToList();
        Console.WriteLine(string.Join(", ", first5Names));

        // Output the last 3 animal IDs
        Console.WriteLine("\nLast 3 Animal IDs:");
        var last3IDs = sortedAnimals.Skip(sortedAnimals.Count - 3).Select(a => a.ID).ToList();
        Console.WriteLine(string.Join(", ", last3IDs));

        // Write the sorted animals to a file
        WriteAnimalsToFile(sortedAnimals, "animals.txt");

        // Read and display animals from the file
        List<Animal> readAnimals = ReadAnimalsFromFile("animals.txt");
        Console.WriteLine("\nAnimals Read from File:");
        foreach (var animal in readAnimals)
        {
            Console.WriteLine($"ID: {animal.ID}, Name: {animal.Name}, Type: {animal.Type}, Food Required: {animal.CalculateFoodRequired()}");
        }
    }

    // Method to write animals to a file
    static void WriteAnimalsToFile(List<Animal> animals, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var animal in animals)
            {
                writer.WriteLine($"{animal.ID},{animal.Name},{animal.Type}");
            }
        }
    }

    // Method to read animals from a file
    static List<Animal> ReadAnimalsFromFile(string filePath)
    {
        List<Animal> animals = new List<Animal>();
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        string type = parts[2];

                        Animal animal;
                        if (type == "Carnivorous")
                        {
                            animal = new Carnivorous();
                        }
                        else if (type == "Omnivorous")
                        {
                            animal = new Omnivorous();
                        }
                        else if (type == "Herbivorous")
                        {
                            animal = new Herbivorous();
                        }
                        else
                        {
                            throw new Exception($"Invalid animal type: {type}");
                        }

                        animal.ID = id;
                        animal.Name = name;
                        animals.Add(animal);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading from file: {ex.Message}");
        }

        return animals;
    }
}
