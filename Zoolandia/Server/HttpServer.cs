﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zoolandia
{
    public abstract class HttpServer
    {
        protected int port;
        TcpListener listener;
        bool is_active = true;

        public HttpServer(int port)
        {
            this.port = port;
        }

        public void listen()
        {
            listener = new TcpListener(port);
            listener.Start();
            while (is_active)
            {
                TcpClient s = listener.AcceptTcpClient();
                HttpProcessor processor = new HttpProcessor(s, this);
                Thread thread = new Thread(new ThreadStart(processor.process));
                thread.Start();
                Thread.Sleep(1);
            }
        }

        public abstract void handleGETRequest(HttpProcessor p);
        public abstract void handlePOSTRequest(HttpProcessor p, StreamReader inputData);
    }

    public class MyHttpServer : HttpServer
    {
        public MyHttpServer(int port) : base(port)
        {
        }

        // THIS IS THE CORE CONCEPT I NEED TO LEARN
        /// Get animals
        public override void handleGETRequest(HttpProcessor p)
        {
            string heading;
            string message = "";

            p.writeSuccess();

            Console.WriteLine("request: {0}", p.http_url);


            p.outputStream.WriteLine("<html><head><title>Zoolandia</title></head><body>");
            p.outputStream.WriteLine("Current Time: " + DateTime.Now.ToString());

            string[] urlParams = p.http_url.Split('/');
            string type = urlParams[1].ToString();

            switch (type)
            {
                case "animals":
                    Console.WriteLine("Animal route");
                    if (urlParams.Length > 2)
                    {
                        Console.WriteLine("Getting a single animal");
                        AnimalHandler animals = new AnimalHandler();
                        message = animals.getAnimal(urlParams[2]);
                    }
                    else
                    {
                        Console.WriteLine("Getting all animals");
                        AnimalHandler animals = new AnimalHandler();
                        //message = animals.getAllAnimals();
                    }

                    break;
                case "habitats":
                    break;
                case "employees":
                    break;
            }

            p.outputStream.WriteLine(message);
            p.outputStream.WriteLine("</body></html>");
        }

        public override void handlePOSTRequest(HttpProcessor p, StreamReader inputData)
        {
            Console.WriteLine("POST request: {0}", p.http_url);
            string data = inputData.ReadToEnd();

            p.writeSuccess();
            p.outputStream.WriteLine("<html><body><h1>test server</h1>");
            p.outputStream.WriteLine("<a href=/test>return</a><p>");
            p.outputStream.WriteLine("postbody: <pre>{0}</pre>", data);
        }
    }
}
