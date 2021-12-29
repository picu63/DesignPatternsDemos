using System;

namespace CompositePattern;

internal class GraphicsPrinter : Composite
{
    private readonly char _character;

    public GraphicsPrinter(char character)
    {
        _character = character;
    }

    public override void Add(Component component)
    {
        base.Add(component);
        if (component is ICharacterPrinter consolePrinter)
        {
            consolePrinter.Character = _character;
        }
        else
        {
            throw new NotSupportedException($"Nieprawidłowy typ komponentu. Spodziewano się typu {nameof(ICharacterPrinter)}");
        }
    }
}