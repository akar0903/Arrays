using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            int len = words.Length;
            for (int i = 0; i < len; i++)
            {
                char[] rev = words[i].ToCharArray();
                Array.Reverse(rev);
                words[i] = new string(rev);
            }
            string reversedString = string.Join(" ", words);
            Console.WriteLine(reversedString);

            Console.ReadLine();
        }
    }
}