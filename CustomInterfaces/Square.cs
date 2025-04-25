using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    class Square : Shape, IRegularPointy
    {
        public Square() { }
        public Square(string name) : base(name)
        {
            
        }

        //метод Draw() поступает из базового класса Shape
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
        // это свойство поступает из интерфейса IPointy
        public byte Points => 4;

        // это свойство поступает из интерфейса IPointy
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }
        //обратите внимание, что свойство периметр не реализовано.

    }
}
