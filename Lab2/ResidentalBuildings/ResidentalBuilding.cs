using Lab2.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.ResidentalBuildings
{
    class ResidentalBuilding : Construction
    {
        public ResidentalBuilding(int floors)
        {
            NumberOfFloors = floors;
        }
        public int NumberOfFloors { get; set; }

    }
}
