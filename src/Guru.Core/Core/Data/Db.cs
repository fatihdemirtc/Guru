using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guru.Core.Data
{
    public class Db
    {

        static Db instance = null;
        public static Db Instance
        {
            get
            {
                if (instance == null)
                    instance = new Db();
                return instance;
            }
        }

        public string Server
        {
            set
            {
                client = new MongoClient(value);
            }
        }
        public string DatabaseName {
            set
            {
                if (Client == null)
                    throw new ArgumentException("Place before fill Client propertie", "Client");
                database = Client.GetDatabase(value);
            }
        }


        private IMongoDatabase database;

        public IMongoDatabase Database
        {
            get { return database; }
        }

        private MongoClient client;

        public MongoClient Client
        {
            get { return client; }
        }


        public IMongoCollection<T> GetCollection<T>()
        { 
            return database.GetCollection<T>(typeof(T).Name);
        }
    }
}
