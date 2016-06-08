using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Diagnostics;


namespace Mongodb
{
    class Program
    {
        static void Main(string[] args)
        {

            //mongodb2.2.3

            //MongoClient mongoClient = new MongoClient("mongodb://192.168.2.118:8888");     //连接mongodb服务端
            //var database = mongoClient.GetDatabase("test");                                //获取sechme
            //var collection = database.GetCollection<BsonDocument>("person");               //获取到表
            //collection.InsertOneAsync(new BsonDocument(new BsonElement[] { new BsonElement("id", 100001), new BsonElement("name", "jack"), new BsonElement("age", 11) }));   //插入新数据
            //var list = collection.Find(new BsonDocument("name", "jack")).ToList();         //获取名字为jack的集合



            //mongodb1.8.1
            //mongodb://administrator:password123@widmore.mongohq.com:10010/MyFirstDb

            MongoDB.Driver.MongoClient mongodClient = new MongoClient("mongodb://192.168.2.118:8888");

            MongoServer mongodServer = mongodClient.GetServer();

            MongoDatabase mongodBase = mongodServer.GetDatabase("test");

            while (true)
            {
                //Console.Write("start?");
               // Console.ReadKey();


                Stopwatch watch = new Stopwatch();

                watch.Start();
                watch.Stop();

                Stopwatch watch2 = new Stopwatch();
                watch2.Start();

                mongodServer.GetDatabase("test").GetCollection("person").FindAll().SetSortOrder("age");

                Console.WriteLine("time:{0}", watch2.Elapsed);

                Console.ReadKey();

                Stopwatch watch1 = new Stopwatch();

                watch1.Start();

                mongodServer.GetDatabase("test").GetCollection("person").FindAll().SetSortOrder("age");

                Console.WriteLine("time:{0}", watch1.Elapsed);

            }


            Console.ReadKey();

        }
    }

    public class Person
    {

        [MongoDB.Bson.Serialization.Attributes.BsonId]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
