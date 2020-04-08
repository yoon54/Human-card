using System;
using DemoOOP.Models;

namespace DemoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm Down with OOP! Yeah, you know me.");
            Human John = new Human("Mr. John");
            John.ShowStats();
            Human Jacob = new Human("Jacob",10,30,50);
            Jacob.ShowStats();
            Jacob.Attack(John);
            John.ShowStats();
        }
    }
}