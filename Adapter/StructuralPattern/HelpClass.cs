using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.StructuralPattern
{
    public class HelpClass
    {
        public HelpClass() { }
        public int ArrayIndex(object[] obj, object obj1)
        {
            int num = -1;
            for (int i = 0; i < obj.Length; i++)
                if (obj[i] == obj1) { num = i; break; }
            return num;
        }
        public object[] RemoveArray(object[] obj, object obj1)
        {
            int num = ArrayIndex(obj, obj1);
            if (num >= 0)
                obj = obj.Where((source, index) => index != num).ToArray();
            return obj;

        }
    }
}
