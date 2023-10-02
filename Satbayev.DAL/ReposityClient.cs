using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.DAL
{
    internal class ReposityClient
    {
        
        private string Path;
        public ReposityClient(string Path)
        {
            this.Path = Path;
        }
        public bool CreateClient(Client client)
        {
            using (var db = new LiteDatabase(Path))
            {
                // Get a collection (or create, if doesn't exist)
                var clients = db.GetCollection<Client>("Client");
                clients.Insert(client);

            }
            return true;
        }
        public Client GetClient(string email, string password)
        {
            using (var db = new LiteDatabase(Path))
            {
                return db.GetCollection<Client>("Client").FindAll().First(f=>f.Email==email & f.Password==password);
            }
        }
        public Client GetClient(int id)
        {
            using (var db = new LiteDatabase(Path))
            {
                return db.GetCollection<Client>("Client").FindAll().First(f => f.id == id);
            }
        }
    }
}