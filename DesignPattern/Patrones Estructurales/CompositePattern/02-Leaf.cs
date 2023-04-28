using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patrones_Estructurales.CompositePattern
{
    // La clase Leaf representa los objetos finales de una composición. 
    // Por lo general, son los objetos Leaf los que hacen el trabajo real,
    // mientras que los objetos Composite solo delegan en sus subcomponentes.
    class Leaf : Component
    {
        public int Cantidad { get; set; }
        public string Unidad { get; set; }

        public Leaf(string Nombre, decimal Costo, int Cantidad, string Unidad)
            : base(Nombre, Costo)
        { 
            this.Cantidad = Cantidad;
            this.Unidad = Unidad;
        }
    }
}