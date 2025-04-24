using System;
using CustomInterfaces;



Console.WriteLine("***** Fun with Interfaces *****\n");

Circle c = new Circle("Lisa");
IPointy itfPt = null;
try
{
    itfPt = (IPointy)c;
    Console.WriteLine(itfPt.Points);
}
catch (InvalidCastException e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();



Hexagon hex2 = new Hexagon("Peter");
IPointy itfPt2 = hex2 as IPointy;
if (itfPt2 != null)
{
    Console.WriteLine($"Points: {itfPt2.Points}");
}
else
{
    Console.WriteLine("OOPS! Not pointy...");
}
Console.ReadLine();

if(hex2 is IPointy itfPt3)
{
    Console.WriteLine($"Points: {itfPt3.Points}");
}
else
{
    Console.WriteLine("OOPS! Not pointy...");
}
Console.ReadLine();



//CloneableExample();


static void CloneableExample()
    {
        //все эти классы поддерживают интерфейс Icloneable
        string myStr = "Hello";
        OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());

        //следовательно, все они могут быть переданы методу
        //принимающему параметр типа ICloneable
        CloneMe(myStr);
        CloneMe(unixOS);

        static void CloneMe(ICloneable c)
        {
            //клонировать то, что получено и вывести имя
            object theClone = c.Clone();
            Console.WriteLine($"Your clone is a: {theClone.GetType().Name}");
        }

    }
