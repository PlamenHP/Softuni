﻿namespace _01.Action_Print
{
    using System;

            Action<string> namePrinter = x => Console.WriteLine(x);

        private static void InvokePrint(string[] data, Action<string> namePrinter)
        {
            foreach (var item in data)
            {
                namePrinter(item);
            }
        }
    }
}