using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patrones_Estructurales.CompositePattern
{
    // La clase Component declara operaciones comunes para objetos simples y complejos de una composición.
    abstract class Component
    {
        public string Nombre { get; set; }
        public decimal Costo { get; set; }

        public Component (string nombre, decimal costo)
        {
            this.Nombre = nombre;
            this.Costo = costo;
        }
    }
}
