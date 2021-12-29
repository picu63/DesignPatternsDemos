using System;
using System.Drawing;

namespace CompositePattern;

internal class RectanglePrinter : Leaf, ICharacterPrinter
{
    private readonly Size _size;
    private readonly Point _point;

    public RectanglePrinter(Size size, Point point)
    {
        _size = size;
        _point = point;
    }

    public override void Operation()
    {
        for (int i = 0; i < _size.Width; i++)
        {
            for (int j = 0; j < _size.Height; j++)
            {
                Console.SetCursorPosition(_point.X+i, _point.Y+j);
                Console.Write(Character);
            }
        }
    }

    public char Character { get; set; }
}