using Lab2.Constructions;
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var construction = new Construction(23, 45, 4, 6, "Brik");
            Console.WriteLine(construction.BuildMaterial);
        }
    }
}
