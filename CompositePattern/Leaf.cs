using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    /// <summary>
    /// Ostatni obiekt w hierarchii - nie posiada child objects.
    /// </summary>
    class Leaf : Component
    {
        public override void Operation()
        {

        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
