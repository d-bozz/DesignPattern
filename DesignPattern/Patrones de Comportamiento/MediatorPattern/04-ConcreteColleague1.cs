using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    // Los componentes concretos implementan varias funciones. No dependen de otros componentes.
    class ConcreteColleague1 : IColleague
    {
        public ConcreteColleague1(IMediator mediator) : base(mediator)
        {

        }

        public override void Receive(string message)
        {
            Console.WriteLine("Un usuario recibe: " + message);
        }
    }
}
