using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Laba2;


class Program
{
    public static void Main()
    {
        Console.WriteLine((new RomanNumber(20) + new RomanNumber(10)));
        Console.WriteLine((new RomanNumber(20) - new RomanNumber(10)));
        Console.WriteLine((new RomanNumber(20) * new RomanNumber(10)));
        Console.WriteLine((new RomanNumber(20) / new RomanNumber(10)));
        RomanNumber[] romanNumberArray = new RomanNumber[10];
        for (int i = 0; i < 10; i++)
        {
            romanNumberArray[i] = new RomanNumber((ushort)(new Random().Next(1, 10)));
            Console.Write(romanNumberArray[i] + " ");
        }
        Console.WriteLine();

        Array.Sort(romanNumberArray);

        for (int i = 0; i < 10; i++)
        {
            Console.Write(romanNumberArray[i] + " ");
        }



    }
}