using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.FactoryPatterns
{
    public interface IMachine
    {
        string Name { get; }
        void TurnOn();
        void TurnOff();
    }
}
