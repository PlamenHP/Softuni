﻿namespace _02.Upper_Strings
{
    using System;

    public class Startup
            string[] names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(x=>x.ToUpper())
                                    .ToArray();

            Console.WriteLine(string.Join(" ", names));
}