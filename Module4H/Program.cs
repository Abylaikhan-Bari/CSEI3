using System;

public class Product
{
    // Private fields representing characteristics of the product
    private string name;
    private int id;
    private double price;
    private bool isAvailable;
    private DateTime manufacturingDate;

    // Static fields for common characteristics of products
    private static int totalProducts = 0;
    private static double totalValueOfProducts = 0.0;

    // Constructors
    public Product()
    {
        // Default constructor
        totalProducts++;
    }

    public Product(string name, int id, double price, bool isAvailable, DateTime manufacturingDate)
    {
        // Parameterized constructor
        this.name = name;
        this.id = id;
        this.price = price;
        this.isAvailable = isAvailable;
        this.manufacturingDate = manufacturingDate;

        totalProducts++;
        totalValueOfProducts += price;
    }

    // Properties to access private fields
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
            {
                totalValueOfProducts -= price;
                price = value;
                totalValueOfProducts += price;
            }
        }
    }

    public bool IsAvailable
    {
        get { return isAvailable; }
        set { isAvailable = value; }
    }

    public DateTime ManufacturingDate
    {
        get { return manufacturingDate; }
        set { manufacturingDate = value; }
    }

    // Method to calculate the total value of all products
    public static double CalculateTotalValueOfProducts()
    {
        return totalValueOfProducts;
    }

    // Method to get the total count of products
    public static int GetTotalProductsCount()
    {
        return totalProducts;
    }

    // Method to display product information
    public void DisplayInformation()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Price: ${price:F2}");
        Console.WriteLine($"Available: {(isAvailable ? "Yes" : "No")}");
        Console.WriteLine($"Manufacturing Date: {manufacturingDate.ToShortDateString()}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an array of Product objects
        Product[] products = new Product[5];

        // Adding products to the array using different constructors
        products[0] = new Product("Laptop", 1, 999.99, true, new DateTime(2022, 5, 15));
        products[1] = new Product("Smartphone", 2, 599.99, true, new DateTime(2022, 6, 10));
        products[2] = new Product("Tablet", 3, 299.99, true, new DateTime(2022, 7, 20));
        products[3] = new Product("Headphones", 4, 49.99, true, new DateTime(2022, 8, 5));
        products[4] = new Product("Monitor", 5, 249.99, true, new DateTime(2022, 9, 30));

        // Displaying product information
        Console.WriteLine("Product Information:");
        foreach (Product product in products)
        {
            product.DisplayInformation();
            Console.WriteLine();
        }

        // Displaying total count and total value of products
        Console.WriteLine($"Total Products Count: {Product.GetTotalProductsCount()}");
        Console.WriteLine($"Total Value of Products: ${Product.CalculateTotalValueOfProducts():F2}");
        Console.ReadKey();
    }
}
