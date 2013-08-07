using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundredprojects.Text
{
    /// <summary>
    /// Check if Palindrome – Checks if the string entered by the user is a palindrome. That is that it reads the same forwards as backwards like “racecar”
    /// </summary>
    public class CheckPalindrome
    {
        public static void Main()
        {
            Console.WriteLine(@"Check if Palindrome – Checks if the string entered by the user is a palindrome. That is that it reads the same forwards as backwards like “racecar”");
            Console.Write("Enter a text: ");
            var text = Console.ReadLine();
            var array = text.ToCharArray();
            Array.Reverse(array);
            var reversedText = new String(array);

            if (text.Equals(reversedText))
            {
                Console.WriteLine("Palindrome!");
            }
            else
            {
                Console.WriteLine("Not Palindrome!");
            }

            Console.ReadLine();
        }
    }
}
