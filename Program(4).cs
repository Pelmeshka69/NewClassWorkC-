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
            Console.Write("Введіть довжину паролю: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Виберіть тип символів (1 - цифри, 2 - букви, 3 - цифри та букви): ");
            int type = Convert.ToInt32(Console.ReadLine());

            string[] passwords = new string[10];

            for (int i = 0; i < 10; i++)
            {
                passwords[i] = GeneratePassword(length, type);
                Console.WriteLine(passwords[i]);
            }
        }

        static string GeneratePassword(int length, int type)
        {
            const string digits = "0123456789";
            const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string characters;

            if (type == 1)
            {
                characters = digits;
            }
            else if (type == 2)
            {
                characters = letters;
            }
            else
            {
                characters = digits + letters;
            }

            Random random = new Random();
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = characters[random.Next(characters.Length)];
            }
            return new string(password);
        }
    }
}