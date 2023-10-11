namespace Bankomat
{
    public class Client
    {
        public string Password { get; private set; }

        public Client(string password)
        {
            Password = password;
        }
    }
}
