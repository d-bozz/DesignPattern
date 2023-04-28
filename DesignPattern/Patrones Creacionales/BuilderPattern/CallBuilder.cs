using DesignPattern.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._07_BuilderPattern
{
    // El código del cliente crea un objeto builder, lo pasa al director y luego inicia el proceso de construcción.
    // El resultado final se recupera del objeto builder.
    class CallBuilder
    {
        static void Main(string[] args)
        {
            var builder = new ConcreteBuilder();
            var director = new Director(builder);

            director.PrepareMargarita();

            var preparedDrink = builder.GetProduct();
            Console.WriteLine(preparedDrink.Result);

            director.PreparePiñaColada();

            preparedDrink = builder.GetProduct();
            Console.WriteLine(preparedDrink.Result);
        }
    }
}
