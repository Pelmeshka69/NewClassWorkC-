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
            int[] one = new int[5];
            int[] two = new int[5];
            int[] three = new int[5];

            for (int i = 0; i < one.Length; i++)
            {
                one[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < two.Length; i++)
            {                
                two[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < three.Length; i++)
            {
                three[i] = one[i] + two[i];
            }

            Console.WriteLine("Сума елементів з першого та другого масивів:");
            for (int i = 0; i < three.Length; i++)
            {
                Console.WriteLine(three[i]);
  
            }
            Console.ReadLine();
        }
    }
}
