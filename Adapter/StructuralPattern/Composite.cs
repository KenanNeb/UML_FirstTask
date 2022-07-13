using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.StructuralPattern
{
    public class Composite : IComponet
    {
        private IComponet[]? _Childern { get; set; }
        private HelpClass _HelpClass { get; set; } = new();
        public Composite() => Console.WriteLine("Composite constructor");

        public void Add(IComponet C) => _Childern[_Childern.Length] = C;

        public void Romove(IComponet C)
            => _Childern = (IComponet[]?)_HelpClass.RemoveArray(_Childern, C);

        public IComponet[] GetChilder() => _Childern;

        public void ExeCute()
        {
            Console.WriteLine("Composite");
        }
    }
}
