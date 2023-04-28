using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patrones_Estructurales.AdapterPattern
{
    // Adaptee contiene algunos comportamientos útiles,
    // pero su interfaz es incompatible con el código de cliente existente.
    // El Adaptado necesita algunas adaptaciopnes antes de que el código del cliente pueda usarla.
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}
