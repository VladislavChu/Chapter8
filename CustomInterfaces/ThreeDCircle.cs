﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    class ThreeDCircle : Circle
    {
        public new string PetName { get; set; }
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}
