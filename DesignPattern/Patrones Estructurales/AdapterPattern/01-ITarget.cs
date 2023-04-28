using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patrones_Estructurales.AdapterPattern
{
    /**
     * El patrón Adapter actúa como envoltorio entre dos objetos. 
     * Atrapa las llamadas a un objeto y las transforma a un formato y una interfaz reconocible para el segundo objeto.
     * **/

    // ITarget define la interfaz específica del dominio utilizada por el código del cliente.
    public interface ITarget
    {
        string GetRequest();
    }
}
