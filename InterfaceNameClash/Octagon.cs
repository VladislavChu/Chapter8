using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        //явно привязать реализации метода к конкретным интерфейсам
        void IDrawToForm.Draw()
        {
            //разделяемая логика вывода.
            Console.WriteLine("Drawing to form...");
        }        
        void IDrawToMemory.Draw()
        {
            //разделяемая логика вывода.
            Console.WriteLine("Drawing to memory...");
        }        
        void IDrawToPrinter.Draw()
        {
            //разделяемая логика вывода.
            Console.WriteLine("Drawing to printer...");
        }
    }
}
