using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patrones_Estructurales.CompositePattern
{
    // La clase Composite representa los componentes complejos que pueden tener niños.
    // Por lo general, los objetos Composite delegan el trabajo real a sus hijos y luego "resumen" el resultado.
    class Composite : Component
    {
        private List<Component> leafList = new List<Component>();

        public decimal CostoTotal
        {
            get
            {
                decimal costo = 0;
                foreach (var oElemento in leafList) 
                {
                    if (oElemento.GetType().Name == "Composite")
                        costo += ((Composite)oElemento).CostoTotal;
                    else
                        costo += oElemento.Costo;
                }
                return costo;
            }
        }

        public void Add(Component oElemento)
        { 
            leafList.Add(oElemento);
        }

        public void Remove(Component oElemento)
        { 
            leafList.Remove(oElemento);
        }

        public Composite(string Nombre, decimal Costo = 0) : base(Nombre, Costo)
        {
        }
    }
}
