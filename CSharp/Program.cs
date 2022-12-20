// See https://aka.ms/new-console-template for more information
using System;

namespace System // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Dime tu nombre");
            name = Console.ReadLine();
            Console.WriteLine("Hola " + name);
        }
    }
}


