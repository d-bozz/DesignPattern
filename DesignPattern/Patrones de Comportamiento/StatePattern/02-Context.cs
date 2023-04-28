using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._08_StatePattern
{
    // El Context define la interfaz de interes para el cliente
    // Mantiene una referencia a una instancia de una subclase State 
    // Que representa el estado actual del contexto
    public class Context
    {
        //Se hace referencia al estado actual del contexto
        private IState _state;
        private decimal _residue;

        public decimal Residue
        {
            get { return _residue; }
            set { _residue = value; }
        }

        public Context() 
        { 
            _state = new ConcreteStateA();
        }

        // El context permite cambiar el objeto State en tiempo de ejecución.
        public void SetState(IState state) => _state = state;
        public IState GetState() => _state;

        // Metodos de la logica de negocios
        public void Request(decimal amount) => _state.Action(this, amount);
        public void Discount(decimal amount) => _residue -= amount;
    }
}
