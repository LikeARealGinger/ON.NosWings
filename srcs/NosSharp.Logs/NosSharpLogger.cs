﻿using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace OpenNos.Logger
{
    public class NosSharpLogger
    {
        protected IMongoClient Client;
        protected IMongoDatabase Database;

        public NosSharpLogger(string database)
        {
            Client = new MongoClient("mongodb://localhost:27017");
            Database = Client.GetDatabase(database);
        }

        public async void InsertLog(BsonDocument log, string collectionName)
        {
            IMongoCollection<BsonDocument> collection = Database.GetCollection<BsonDocument>(collectionName);

            if (collection == null)
            {
                await Database.CreateCollectionAsync(collectionName);
                collection = Database.GetCollection<BsonDocument>(collectionName);
            }
            await collection.InsertOneAsync(log);
        }

        public async void InsertLogs(IEnumerable<BsonDocument> logs, string collectionName)
        {
            IMongoCollection<BsonDocument> collection = Database.GetCollection<BsonDocument>(collectionName);

            if (collection == null)
            {
                await Database.CreateCollectionAsync(collectionName);
                collection = Database.GetCollection<BsonDocument>(collectionName);
            }
            await collection.InsertManyAsync(logs);
        }

        public IMongoCollection<BsonDocument> GetCollectionByName(string collectionName)
        {
            return Database.GetCollection<BsonDocument>(collectionName);
        }
    }
}