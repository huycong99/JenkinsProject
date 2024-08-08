﻿using Serilog;

namespace JenkinsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = new LoggerConfiguration();
            logger.WriteTo.Console().CreateLogger();
            Console.Write(ConsoleColor.Green);

            Console.WriteLine("Hello, World!");
        }
    }
}