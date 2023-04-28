using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._08_StatePattern
{
    /**
     * State es un patrón de diseño de comportamiento que permite a un objeto cambiar de comportamiento 
     * cuando cambia su estado interno.
     * **/

    // La interfaz IState declara los metodos que todo concrete state debe implementar
    public interface IState
    {
        public void Action(Context context, decimal amount);
    }
}