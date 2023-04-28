using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._08_StatePattern
{
    // Los Estados Concretos implementan varios comportamientos, asociados a un estado del Contexto.
    public class ConcreteStateC : IState
    {
        public void Action(Context context, decimal amount)
        {
            Console.WriteLine("No puedes comprar ya que eres un deudor");
        }
    }
}
