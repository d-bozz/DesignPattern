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
    public class ConcretStrategyA : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy un carro y me muevo con 4 llantas");
        }
    }
}
