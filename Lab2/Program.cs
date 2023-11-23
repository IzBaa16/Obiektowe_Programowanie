using Lab2.IndustriallHalls;
using Lab2.ResidentalBuildings;
using Lab2.Constructions;
using Lab2.Constructions.Models;
using System;
using Lab2.BuildingWrappers;

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
            var industrialHall = new IndustriallHall();
            var residentalBuilding = new ResidentalBuilding(2);

            Console.WriteLine(industrialHall.BuildMaterial);
            Console.WriteLine(industrialHall.Height);
            Console.WriteLine(industrialHall.Width);
            Console.WriteLine(residentalBuilding.BuildMaterial);
            Console.WriteLine(residentalBuilding.Height);
            Console.WriteLine(residentalBuilding.Width);
            Console.WriteLine(residentalBuilding.GetSquareCost());

            var wrapper1 = new BuildingWrapper(industrialHall);
            var wrapper2 = new BuildingWrapper(residentalBuilding);
            Console.WriteLine(wrapper1.GetWrappedSquareCost());
            Console.WriteLine(wrapper2.GetWrappedSquareCost());
           

        }
    }
}   
