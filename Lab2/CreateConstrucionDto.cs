using Lab2.Constructions.Models;
using System;

namespace Lab2
{
    internal class CreateConstrucionDto
    {
        public CreateConstrucionDto()
        {
        }

        public BuildMaterialType BuildMaterial { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }

        //public static implicit operator CreateConstrucionDto(CreateConstrucionDto v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}