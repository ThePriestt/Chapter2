using System;

//  Декларирайте променлива от тип char и присвоете като стойност символа който има Unicode код 72 
// (използвайте калкулатора на Windows за да намерите шестнайсетичното представяне на 72).

class Program
{
    static void Main()
    {
        char symbol = '\u0072'; //r
        Console.WriteLine(symbol);
    }
}
