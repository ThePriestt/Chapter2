using System;
using System.Text;

// Напишете програма, която принтира на конзолата равнобедрен триъгълник, като страните му са очертани от символа звездичка "©".

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("                            \u00a9                                            ");
        Console.WriteLine("                           \u00a9 \u00a9                                      ");
        Console.WriteLine("                          \u00a9   \u00a9                                     ");
        Console.WriteLine("                         \u00a9     \u00a9                                    ");
        Console.WriteLine("                        \u00a9       \u00a9                                   ");
        Console.WriteLine("                       \u00a9 \u00a9 \u00a9 \u00a9 \u00a9 \u00a9              ");
    }
}

