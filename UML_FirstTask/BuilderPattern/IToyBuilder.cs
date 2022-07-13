using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_FirstTask.BuilderPattern
{
    public interface IToyBuilder
    {
        void SetModel();
        void SetHead();
        void SetLimbs();
        void SetBody();
        void SetLegs();
        Toy GetToy();
    }
}
