﻿namespace _01.Sort_Even_Numbers
{
    using System;

    public class Startup
                                    .Split(new[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            var evenNumbers = nums.Where(x => x % 2 == 0).OrderBy(x => x);
            Console.Write(  string.Join(", ", evenNumbers));
        }
}