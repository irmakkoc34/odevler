﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodev2
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "ırmak yemek yedi";
            string[] b = a.Split(' ');

            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
