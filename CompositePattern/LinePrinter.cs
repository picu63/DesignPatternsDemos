using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern;

class LinePrinter : Leaf, ICharacterPrinter
{
    private readonly int _length;
    private readonly Point _point;
    private readonly bool _isVertical;

    public LinePrinter(int length, Point startPoint, bool isVertical)
    {
        _length = length;
        _point = startPoint;
        _isVertical = isVertical;
    }
        
    public override void Operation()
    {
        for (int i = 0; i < _length; i++)
        {
            if (_isVertical)
            {
                Console.SetCursorPosition(_point.X, _point.Y + i);
            }
            else
            {
                Console.SetCursorPosition(_point.X + i, _point.Y);
            }

            Console.Write(Character);
        }
    }

    public char Character { get; set; }
}