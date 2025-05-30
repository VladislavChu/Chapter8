﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    public interface IRegularPointy : IPointy
    {
        int SideLength { get; set; }
        int NumberOfSides { get; set; }
        int Perimeter => SideLength * NumberOfSides;

        //статические члены также разрешены в версии С# 8.
        static string ExampleProperty { get; set; }
        static IRegularPointy() => ExampleProperty = "Foo";
    }
}
