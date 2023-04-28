using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._08_StatePattern
{
    // Los Estados Concretos implementan varios comportamientos, asociados a un estado del Contexto.
    public class ConcreteStateA : IState
    {
        public void Action(Context customerContext, decimal amount)
        {
            Console.WriteLine($"Se le pone dinero a su saldo {amount}");
            customerContext.Residue = amount;
            customerContext.SetState(new ConcreteStateB());
        }
    }
}