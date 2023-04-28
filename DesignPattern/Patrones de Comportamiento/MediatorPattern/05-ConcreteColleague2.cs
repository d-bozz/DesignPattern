using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ConcreteColleague2 : IColleague
    {
        public ConcreteColleague2(IMediator mediator) : base(mediator)
        {

        }

        public override void Receive(string message)
        {
            Console.WriteLine("Un administrador recibe: "+message);
            Console.WriteLine("Se notifico por mail");
        }
    }
}
