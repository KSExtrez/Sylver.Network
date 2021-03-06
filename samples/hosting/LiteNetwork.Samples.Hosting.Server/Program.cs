﻿using LiteNetwork.Server.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace LiteNetwork.Samples.Hosting.Server
{
    class Program
    {
        static Task Main(string[] args)
        {
            Console.Title = "LiteNetwork Hosting Sample";

            var host = new HostBuilder()
                .UseLiteServer<ICustomServer, CustomServer, ServerUser>((host, options) =>
                {
                    options.Host = "127.0.0.1";
                    options.Port = 4444;
                })
                .UseConsoleLifetime()
                .Build();

            return host.RunAsync();
        }
    }
}
