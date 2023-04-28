using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern
{
    // Concrete Strategy
    // Se implementa el algoritmo siguiendo la base Interface.
    // La interfaz los hace intercambiables en el Contexto.
    public class ConcretStrategyA1 : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una motocicleta y me muevo con 2 llantas");
        }
    }
}
