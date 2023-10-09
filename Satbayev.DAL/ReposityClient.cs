using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.DAL
{
    public class ReposityClient
    {
        
        private string Path;
        public ReposityClient(string Path)
        {
            this.Path = Path;
        }
        public bool CreateClient(Client client)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    // Get a collection (or create, if doesn't exist)
                    var clients = db.GetCollection<Client>("Client");
                    clients.Insert(client);

                }
            }
            catch (Exception ex)
            {
                var err = ex;
                throw;
            }
            return true;
        }

        public Client GetClient(string email, string password)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    return db.GetCollection<Client>("Client").FindAll().First(f => f.Email == email & f.Password == password);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Client GetClient(int id)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    return db.GetCollection<Client>("Client").FindAll().First(f => f.Id == id);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}