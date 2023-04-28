using DesignPattern._07_BuilderPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._08_StatePattern
{
    public class CallState
    {
        static void Main(string[] args)
        {
            var customerContext = new Context();
            Console.WriteLine(customerContext.GetState());
            customerContext.Request(100);

            customerContext.Request(50);
            Console.WriteLine(customerContext.GetState());
        }
    }
}