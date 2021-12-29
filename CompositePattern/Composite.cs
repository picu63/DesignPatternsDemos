using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern;

class Composite : Component
{
    protected List<Component> Children = new();

    public override void Operation()
    {
        foreach (var child in Children)
        {
            child.Operation();
        }
    }

    public override void Add(Component component)
    {
        this.Children.Add(component);
    }
    public override void Remove(Component component)
    {
        this.Children.Remove(component);
    }
}