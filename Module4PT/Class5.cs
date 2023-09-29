using System;
using System.Collections.Generic;

class Train
{
    public int TrainNumber { get; set; }
    public string DepartureStation { get; set; }
    public string DestinationStation { get; set; }
    public DateTime DepartureTime { get; set; }
    public decimal TicketPrice { get; set; }
    public int AvailableSeats { get; set; }

    public Train(int trainNumber, string departureStation, string destinationStation, DateTime departureTime, decimal ticketPrice, int availableSeats)
    {
        TrainNumber = trainNumber;
        DepartureStation = departureStation;
        DestinationStation = destinationStation;
        DepartureTime = departureTime;
        TicketPrice = ticketPrice;
        AvailableSeats = availableSeats;
    }

    public override string ToString()
    {
        return $"Train {TrainNumber} - {DepartureStation} to {DestinationStation}, Departure: {DepartureTime}, Price: {TicketPrice:C}, Seats Available: {AvailableSeats}";
    }
}

class Passenger
{
    public string Name { get; set; }
    public string DestinationStation { get; set; }
    public DateTime TravelDate { get; set; }
    public int SelectedTrainNumber { get; set; }

    public decimal CalculateTicketPrice(Train train)
    {
        return train.TicketPrice;
    }
}

class Cashier
{
    private List<Train> trains = new List<Train>();

    public void AddTrain(Train train)
    {
        trains.Add(train);
    }

    public Train FindTrain(int trainNumber, string destinationStation, DateTime travelDate)
    {
        foreach (var train in trains)
        {
            if (train.TrainNumber == trainNumber && train.DestinationStation == destinationStation && train.DepartureTime.Date == travelDate.Date)
            {
                return train;
            }
        }
        return null;
    }

    public void BookTicket(Passenger passenger)
    {
        Train selectedTrain = FindTrain(passenger.SelectedTrainNumber, passenger.DestinationStation, passenger.TravelDate);

        if (selectedTrain != null && selectedTrain.AvailableSeats > 0)
        {
            Console.WriteLine($"Ticket booked for {passenger.Name} on {selectedTrain}");
            selectedTrain.AvailableSeats--;
        }
        else
        {
            Console.WriteLine("No available seats for the selected train.");
        }
    }
}

class Program
{
    static void Main()
    {
        Cashier cashier = new Cashier();

        Train train1 = new Train(101, "Station A", "Station B", DateTime.Parse("2023-09-20 08:00:00"), 50.00m, 100);
        Train train2 = new Train(102, "Station A", "Station C", DateTime.Parse("2023-09-20 09:00:00"), 60.00m, 80);

        cashier.AddTrain(train1);
        cashier.AddTrain(train2);

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your destination station: ");
        string destination = Console.ReadLine();

        Console.Write("Enter your travel date (yyyy-MM-dd): ");
        DateTime travelDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Available Trains:");
        foreach (var train in cashier.FindAvailableTrains(destination, travelDate))
        {
            Console.WriteLine(train);
        }

        Console.Write("Enter the train number you want to book: ");
        int selectedTrainNumber = int.Parse(Console.ReadLine());

        Passenger passenger = new Passenger
        {
            Name = name,
            DestinationStation = destination,
            TravelDate = travelDate,
            SelectedTrainNumber = selectedTrainNumber
        };

        cashier.BookTicket(passenger);
    }
}
