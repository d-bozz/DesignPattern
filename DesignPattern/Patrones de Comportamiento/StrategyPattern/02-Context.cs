using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern
{
    // El contexto define la interfaz de interes para el cliente
    public class Context
    {
        // El contexto mantiene una referencia a uno de los objetos de strategy sin conocer la clase concreta
        private IStrategy _strategy;

        public IStrategy Strategy
        {
            set
            {
                _strategy = value;
            }
        }

        // Mandamos la interfaz strategy en el constructor
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // Se implementa un metodo 
        public void Run()
        {
            _strategy.Run();
        }
    }
}
