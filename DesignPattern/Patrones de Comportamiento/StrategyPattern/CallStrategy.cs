using DesignPattern.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._06_StrategyPattern
{
    public class CallStrategy
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcretStrategyA());
            context.Run();
            context.Strategy = new ConcretStrategyA1();
            context.Run();
        }
    }
}
