using System;
using System.Collections.Generic;
using System.Threading;
using Zoolandia.Animals;

namespace Zoolandia
{
    class Zoolandia
    {
        
        public static int Main(string[] args)
        {
            Savanna savanna = new Savanna();
            Aquatic aquarium = new Aquatic();
            Habitat snakePit = new Habitat();
            Habitat aviary = new Habitat();

            savanna.inhabitants = new List<Animal>();

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