using System;
using InterfaceHierarchy;


Console.WriteLine("***** Simple Interface Hierarchy *****");


//вызвать на уровне объекта.
BitmapImage myBitmap = new BitmapImage();
myBitmap.Draw();
myBitmap.DrawInBoundingBox(10, 10, 100, 150);
myBitmap.DrawUpsideDown();

//вызвать IAdvancedDraw явным образом.
if (myBitmap is IAdvancedDraw iAdvDraw)
{
    iAdvDraw.DrawUpsideDown();
}
Console.ReadLine();