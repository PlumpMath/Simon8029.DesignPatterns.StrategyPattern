using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon8029.DesignPatterns.StrategyPattern.Units
{
    public interface IUnit
    {
        int Type { get; set; }
        string Name { get; set; }
        int Speed { get; set; }
    }
}
