﻿namespace _01.Take_Two
{
    using System;

    public class Startup
                                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .Where(x => x >= 10 && x <= 20)
                                    .Distinct()
                                    .Take(2)
                                    .ToArray();

            Console.WriteLine(string.Join(" ",nums));
        }
}