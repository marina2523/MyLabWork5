// See https://aka.ms/new-console-template for more information
using System;
class Exercise2
{
    static void Main()
    {
        const double Pi = 3.14;

        Console.WriteLine("Введите радиус окружности: ");
        try
        {
            double R = Convert.ToDouble(Console.ReadLine());

            double L = R*(2 * Pi);
            Console.WriteLine(String.Format("Длина: {1} \n Площадь: {1}", R, Pi * R * R));

        }
        catch (FormatException e)
        {
            Console.Error.WriteLine("Радиус окружности введен неверно! ");
        }
    }
}