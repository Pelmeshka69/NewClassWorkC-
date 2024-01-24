using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] masiv = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                masiv[i] = int.Parse(input[i].ToString());
            }
            Console.Write("Масив розрядів: ");
            for (int i = 0; i < masiv.Length; i++)
            {
                Console.Write(masiv[i]);
                if (i < masiv.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.ReadLine();
        }
    }
}