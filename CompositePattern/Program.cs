using System;
using System.Drawing;

namespace CompositePattern;

class Program
{
    static void Main(string[] args)
    {
        Composite printer = new();
        Composite graphicsPrinter = new GraphicsPrinter('*');
        graphicsPrinter.Add(new LinePrinter(10, new Point(2, 2), false));
        graphicsPrinter.Add(new RectanglePrinter(new Size(9, 5), new Point(15, 7)));
        printer.Add(graphicsPrinter);
        Leaf textPrinter = new TextPrinter("To jest przykładowy string", new Point(30, 12));
        printer.Add(textPrinter);
        printer.Operation();
        Console.ReadKey();
    }
}