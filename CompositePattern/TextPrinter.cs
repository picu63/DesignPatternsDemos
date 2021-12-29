using System;
using System.Drawing;

namespace CompositePattern;

internal class TextPrinter : Leaf
{
    private readonly string _text;
    private readonly Point _startPoint;

    public TextPrinter(string text, Point startPoint)
    {
        _text = text;
        _startPoint = startPoint;
    }

    public override void Operation()
    {
        Console.SetCursorPosition(_startPoint.X, _startPoint.Y);
        Console.Write(_text);
    }
}