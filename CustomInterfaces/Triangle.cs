using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    class Triangle : Shape, IPointy
    {
        public Triangle()
        {
            
        }
        public Triangle(string name) : base (name)
        {
            
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Triangle");
        }
        //реализация IPointy
        //public byte Points
        //{
        //  get { return 3; }
        //}
        public byte Points => 3;
    }
}
