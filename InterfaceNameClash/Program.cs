using System;
using InterfaceNameClash;



Console.WriteLine("***** Fun with Interfaces Name Clashes *****\n");


Octagon oct = new Octagon();

IDrawToForm itfForm = (IDrawToForm)oct;
itfForm.Draw();

((IDrawToPrinter)oct).Draw();

if (oct is IDrawToMemory dtm)
{
    dtm.Draw();
}