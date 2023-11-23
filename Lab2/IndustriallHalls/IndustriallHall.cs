using Lab2.Constructions;
using Lab2.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.IndustriallHalls
{
    class IndustriallHall : Construction
    {
        public IndustriallHall(): base(23, 12, 12, 1, BuildMaterialType.Concrete)
        {
            Console.WriteLine("Constructor of indystial hall");
        }
    }
}
