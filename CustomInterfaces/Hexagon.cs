﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    class Hexagon : Shape, IPointy
    {
        public Hexagon()
        {
            
        }

        public Hexagon(string name) : base (name)
        {
            
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Hexagon");
        }
        //реализация IPointy
        public byte Points => 6;
    }
}
