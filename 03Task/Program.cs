using System;

// Напишете програма, която изчислява вярно променливи с плаваща запетая с точност до 0.000001.

class Program
{
    static void Main()
    {
        decimal firstNumber = 10m;
        decimal secondNumber = 3m;

        double fourthNumber = 10d;
        double fifthNumber = 3d;

        float sixthNumber = 10f;
        float seventhNumber = 3f;

        Console.WriteLine(firstNumber / secondNumber);
        Console.WriteLine(fourthNumber / fifthNumber);
        Console.WriteLine(sixthNumber / seventhNumber);
        
        // 3.3333333333333333333333333333 - decimal
        // 3.33333333333333 - double
        // 3.333333 - float
    }
}

