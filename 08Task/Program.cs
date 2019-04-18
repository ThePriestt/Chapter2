using System;

// Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World". Декларирайте променлива от тип object и и присвоете стойността на конкатенацията на двете
// променливи от тип string (не изпускайте интервала по средата). Декларирайте трета променлива от тип string и я инициализирайте със стойността на променливата от тип object 
// ( трябва да използвате type casting).

class Program
{
    static void Main()
    {
        string hello = "Hellow";
        string world = "World";
        object expression = hello + " " + world;
        string statement = (string)expression; // casting 
        Console.WriteLine(statement);
    }
}
