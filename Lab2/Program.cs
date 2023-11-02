using Lab2.Constructions;
using Lab2.Constructions.Models;
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var construction = new Construction(23, 45, 4, 6, BuildMaterialType.Concrete);
            var construction2 = new Construction();
            var construction3 = new Construction();
            var input = new CreateConstrucionDto()
            {
                BuildMaterial = BuildMaterialType.Wood,
                Width = 2,
                Height = 12,
                Entrances = 2,
                HumanCapacity = 2,
            };
            Console.WriteLine(construction.BuildMaterial);
            Console.WriteLine(construction2.BuildMaterial);
            Console.WriteLine(construction3.BuildMaterial);
           /* Console.WriteLine(construction.Entrances);
            Console.WriteLine(construction.Height);
            Console.WriteLine(construction.HumanCapacity); */
        }
    }
}   
