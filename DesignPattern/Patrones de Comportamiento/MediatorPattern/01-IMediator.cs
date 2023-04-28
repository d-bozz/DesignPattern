using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    /**
     * permite reducir las dependencias caóticas entre objetos. 
     * El patrón restringe las comunicaciones directas entre los objetos, 
     * forzándolos a colaborar únicamente a través de un objeto mediador.
     * **/

    // La interfaz Mediator declara un método utilizado por los componentes para notificar al mediador sobre varios eventos.
    public interface IMediator
    {
        void Send(string message, IColleague colleague);
    }
}
