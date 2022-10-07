// See https://aka.ms/new-console-template for more information
using System;
class Exercise3
{
    static void Main()
    {
        Console.WriteLine("Прошло дня:");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Полных недель: ");
        Console.WriteLine(i / 7);
    }
}