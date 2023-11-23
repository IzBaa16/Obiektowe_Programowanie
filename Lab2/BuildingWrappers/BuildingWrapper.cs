using Lab2.Constructions;
using Microsoft.Build.Logging.StructuredLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.BuildingWrappers
{
    class BuildingWrapper
    {
        public BuildingWrapper(Constructions.Construction construction)
        {
            _construction = construction;
        }
        public Constructions.Construction _construction { get; set; }
        public double GetWrappedSquareCost()
        {
            return _construction.GetSquareCost();
        }
    }

}
