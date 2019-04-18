using System;

// Декларирайте две променливи от тип string и им присвоете стойност "The "use" of quotations causes difficulties." (без първите и последни кавички). 
// В едната променлива използвайте quoted string, а в другата не го използвайте.

class Program
{
    static void Main(string[] args)
    {
        string firstString = "The \"use\" of quotations causes difficulties.";
        // string secondString = @"The "use" of quotations causes difficulties.";
        string secondString = "The \u0022use\u0022 of quotations causes difficulties.";
        Console.WriteLine(firstString);
        Console.WriteLine(secondString);
    }
}

