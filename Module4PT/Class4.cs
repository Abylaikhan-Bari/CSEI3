using System;
using System.Collections.Generic;

class Car
{
    public string Model { get; set; }
    public string LicensePlate { get; set; }
    public bool IsAvailable { get; set; } = true;

    public override string ToString()
    {
        return $"{Model} ({LicensePlate})";
    }
}

class Driver
{
    public string Name { get; set; }
    public Car AssignedCar { get; set; }
    public bool IsAvailable { get; set; } = true;

    public void MarkComplete()
    {
        Console.WriteLine($"{Name} has completed the trip.");
        AssignedCar.IsAvailable = true;
    }

    public void RequestMaintenance()
    {
        Console.WriteLine($"{Name} has requested maintenance for the car: {AssignedCar.Model} ({AssignedCar.LicensePlate}).");
    }

    public override string ToString()
    {
        return Name;
    }
}

class Dispatcher
{
    private List<Driver> drivers = new List<Driver>();
    private List<Car> cars = new List<Car>();

    public void AddDriver(Driver driver)
    {
        drivers.Add(driver);
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void AssignDriverToCar(Driver driver, Car car)
    {
        if (driver.IsAvailable && car.IsAvailable)
        {
            driver.AssignedCar = car;
            car.IsAvailable = false;
            driver.IsAvailable = false;
            Console.WriteLine($"{driver.Name} has been assigned to {car.Model} ({car.LicensePlate}).");
        }
        else
        {
            Console.WriteLine("Driver or car is not available for assignment.");
        }
    }

    public void SuspendDriver(Driver driver)
    {
        driver.IsAvailable = false;
        Console.WriteLine($"{driver.Name} has been suspended from work.");
    }

    public void ListAvailableDrivers()
    {
        Console.WriteLine("Available Drivers:");
        foreach (var driver in drivers)
        {
            if (driver.IsAvailable)
            {
                Console.WriteLine(driver);
            }
        }
    }

    public void ListAvailableCars()
    {
        Console.WriteLine("Available Cars:");
        foreach (var car in cars)
        {
            if (car.IsAvailable)
            {
                Console.WriteLine(car);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Dispatcher dispatcher = new Dispatcher();

        Car car1 = new Car { Model = "Toyota Camry", LicensePlate = "ABC123" };
        Car car2 = new Car { Model = "Honda Accord", LicensePlate = "XYZ456" };

        Driver driver1 = new Driver { Name = "John" };
        Driver driver2 = new Driver { Name = "Alice" };

        dispatcher.AddCar(car1);
        dispatcher.AddCar(car2);

        dispatcher.AddDriver(driver1);
        dispatcher.AddDriver(driver2);

        dispatcher.ListAvailableCars();
        dispatcher.ListAvailableDrivers();

        dispatcher.AssignDriverToCar(driver1, car1);

        dispatcher.ListAvailableCars();
        dispatcher.ListAvailableDrivers();

        driver1.MarkComplete();

        dispatcher.ListAvailableCars();
        dispatcher.ListAvailableDrivers();

        driver2.RequestMaintenance();

        dispatcher.SuspendDriver(driver2);

        dispatcher.ListAvailableCars();
        dispatcher.ListAvailableDrivers();
    }
}
