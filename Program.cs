﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    internal class Program
    {
        class User
        {
            public string Name { get; set; }
            public string Location { get; set; }
        }
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Fatema Patel";
            u.Location = "Hmt";
            Console.WriteLine("Name: " + u.Name);
            Console.WriteLine("Location: " + u.Location);
            Console.ReadLine();
        }
    }
}