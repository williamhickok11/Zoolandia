using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading;
using Zoolandia.Model;

namespace Zoolandia
{
    class Zoolandia
    {
        
        public static int Main(string[] args)
        {
            Database.SetInitializer<ZoolandiaDbContext>(null);


            //Savanna savanna = new Savanna();
            //Aquatic aquarium = new Aquatic();
            //Habitat snakePit = new Habitat();
            //Habitat aviary = new Habitat();

            //savanna.inhabitants = new List<Animal>();


            //AnimalHandler animals = new AnimalHandler();
            //animals.getAnimal("1");
            HttpServer httpServer;
            if (args.GetLength(0) > 0)
            {
                httpServer = new MyHttpServer(Convert.ToInt16(args[0]));
            }
            else
            {
                httpServer = new MyHttpServer(8080);
            }
            Thread thread = new Thread(new ThreadStart(httpServer.listen));
            thread.Start();
            return 0;
        }
    }
}