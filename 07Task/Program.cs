using System;

// Декларирайте две променливи от тип string със стойности "Hello" и "World". Декларирайте променлива от тип object. Присвоете на тази променлива стойността, която се получава 
// от конкатенацията на двете стрингови променливи(добавете интервал, ако е необходимо). Отпе­чатайте променливата от тип object.

class Program
{
    static void Main()
    {
        string hello = "Hellow";
        string world = "World";
        object expression = hello + " " + world;
        Console.WriteLine(expression);
    }
}

