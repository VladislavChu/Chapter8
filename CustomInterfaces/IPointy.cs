using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    public interface IPointy
    {
        //неявно открытый и абстрактный
        //byte GetNumberOfPoints();
        byte Points { get; }
    }
}
