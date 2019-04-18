using System;

// Декларирайте две променливи от тип int. Задайте им стойности съответно 5 и 10. Разменете стойностите им и ги отпечатайте.

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        int temp;

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("a = {0}, b = {1}", a, b);        
    }
}

