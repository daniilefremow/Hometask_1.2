using System;

namespace Hometask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            string[] num = str.Split(' ');

            Console.Write("Четные элементы:");

            for (int i = 0; i < num.Length; i++)
            {
                if (int.Parse(num[i]) % 2 == 0)
                {
                    Console.Write(" {0}", num[i]);
                }
            }
            Console.ReadLine();
        }
    }
}