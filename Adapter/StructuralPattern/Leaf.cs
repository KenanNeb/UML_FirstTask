using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.StructuralPattern
{
    public class Leaf : IComponet
    {
        public void ExeCute()
        {
            Console.WriteLine("Leaf is here");
        }
    }
}
