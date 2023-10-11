public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class PersonUtility
{
    public static string GetPersonInfo(Person person)
    {
        return $"Name: {person.Name}, Age: {person.Age}";
    }
}
