﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    class Principale
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Test GitHub";
            int n = 0;
            Metodi.Inserimento(ref n);

            Console.WriteLine("...");
            Console.ReadKey();
        }
    }
}
