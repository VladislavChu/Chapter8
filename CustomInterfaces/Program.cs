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



//IRegularPointy sq = new Square("Boxy") {NumberOfSides = 4, SideLength = 4 };
var sq = new Square("Boxy") {NumberOfSides = 4, SideLength = 4 };
sq.Draw();
Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter of {((IRegularPointy)sq).Perimeter}");
Console.ReadLine();

Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");
IRegularPointy.ExampleProperty = "Updated";
Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");


//будет рисовать любую фигуру, поддерживающую IDraw3D.
static void DrawIn3D(IDraw3D itf3d)
{
    Console.WriteLine("-> Drawing IDraw3D compatible type");
    itf3d.Draw3D();
}
Console.ReadLine();


Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };
for (int i = 0; i < myShapes.Length; i++)
{
    if (myShapes[i] is IDraw3D s)
    {
        DrawIn3D(s);
    }
}
Console.ReadLine();





//Этот массив может содержать только типы,
//которые реализуют интерфейс IPointy
IPointy[] myPointyObjects = { new Hexagon(), new Knife(), new Triangle(), new Fork(), new PitchFork() };
foreach (IPointy i in myPointyObjects)
{
    Console.WriteLine($"Object has {i.Points} points");
}
Console.ReadLine();



//этот метод возвращает первый объект в массиве,
//который реализует интерфейс IPointy.
static IPointy FindFirstPointyShape(Shape[] shapes)
{
    foreach  (Shape s in shapes)
    {
        if(s is IPointy ip)
        {
            return ip;
        }
    }
    return null;
}

IPointy firstPointyItem = FindFirstPointyShape(myShapes);
Console.WriteLine($"The item has {firstPointyItem?.Points} points");
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
