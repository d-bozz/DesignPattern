using MediatorDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patrones_de_comportamiento.MediatorPattern
{
    public class CallMediator
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediador = new ConcreteMediator();

            IColleague oPepe = new ConcreteColleague1(mediador);
            IColleague oAdmin = new ConcreteColleague2(mediador);
            IColleague oAdmin2 = new ConcreteColleague2(mediador);

            mediador.Add(oPepe);
            mediador.Add(oAdmin);
            mediador.Add(oAdmin2);

            oPepe.Communicate("Oye admin tengo un problema");
        }
    }
}