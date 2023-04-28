using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._08_StatePattern
{
    // Los Estados Concretos implementan varios comportamientos, asociados a un estado del Contexto.
    public class ConcreteStateB : IState
    {
        public void Action(Context customerContext, decimal amount)
        {
            if (amount <= customerContext.Residue)
            {
                customerContext.Discount(amount);
                Console.WriteLine($"Solicitud permitida, gasta {amount} y le queda de saldo {customerContext.Residue}");
                if (customerContext.Residue <= 0)
                    customerContext.SetState(new ConcreteStateC());
            }
            else
            {
                Console.WriteLine($"No ajustas a lo solicitado, " +
                    $"Ya que tienes {customerContext.Residue} " +
                    $"y quieres gastar {amount}");
            }
        }
    }
}