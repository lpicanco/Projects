﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundredprojects.Text
{
    /// <summary>
    /// Reverse a String – Enter a string and the program will reverse it and print it out.
    /// </summary>
    public class ReverseString
    {
        public static void Main()
        {
            Console.WriteLine("Reverse a String – Enter a string and the program will reverse it and print it out.");
            Console.Write("Enter a text: ");
            var text = Console.ReadLine();

            var array = text.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine("Reversed text: {0}",  new String(array));

            Console.ReadLine();
        }
    }
}
