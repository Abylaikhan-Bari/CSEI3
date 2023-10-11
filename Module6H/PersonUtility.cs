namespace MyLibraryNamespace
{
    public class PersonUtility
    {
        public static string GetPersonInfo(Person person)
        {
            return $"Name: {person.Name}, Age: {person.Age}";
        }
    }
}
