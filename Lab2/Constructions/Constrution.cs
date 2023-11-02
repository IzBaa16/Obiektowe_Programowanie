using Lab2.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Constructions
{
    class Construction
    {
        //zad4
        public Construction(double height, double width, int entrances,
            int humanCapacity, BuildMaterialType buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }
        public Construction()
        {
            Height = 21;
            Width = 12;
            Entrances = 1;
            HumanCapacity = 2;
            BuildMaterial = BuildMaterialType.Wood;
        }

        public Construction(CreateConstructionDto input)
        {
            Height = input.Height;
            Width = input.Width;
            Entrances = input.Entrances;
            HumanCapacity = input.HumanCapacity;
            BuildMaterial = input.BuildMaterial;
        }

        //zad3
        public double Height { get; set; }
        public double Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }

        public BuildMaterialType BuildMaterial
        {
            get
            {
                return _buildMaterial;
            }
            set
            {
                // if (value == string.Empty)
                //{
                //    throw new ArgumentNullException();
                //}
                _buildMaterial = value;
            }
        }
        private BuildMaterialType _buildMaterial { get; set; }

        public double GetSquareCost()
        {
            var x = 0.0;
            if (_buildMaterial == BuildMaterialType.Concrete)
            {
                x = 0.87;
            }
            if (_buildMaterial == BuildMaterialType.Concrete)
            {
                x = 0.8;
            }
            if (_buildMaterial == BuildMaterialType.Concrete)
            {
                x = 0.78;
            }

            return Width * Height * 0.9 * x;
        }


    }
}



