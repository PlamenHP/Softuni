﻿namespace _03.Series_of_Letters
{
    using System;

    public class Startup

            Regex regex = new Regex(@"([A-Za-z])\1+");

            string result = regex.Replace(input, "$1");

            Console.WriteLine(result);
        }
}