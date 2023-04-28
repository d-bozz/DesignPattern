using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern
{
    /**
     * PATRON DE COMPORTAMIENTO  
     * Strategy permite definir una familia de algoritmos,
     * 
     * Usar Strategy cuando tenga muchas clases similares que solo difieren 
     * en la forma en que ejecuta algún comportamiento.
     * **/
    public interface IStrategy
    {
        // La interfaz Strategy declara operaciones comunes a todas las versiones soportadas
        public void Run();
    }
}
