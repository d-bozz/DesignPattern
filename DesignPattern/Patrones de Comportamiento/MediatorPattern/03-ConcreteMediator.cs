using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MediatorDesignPattern
{
    // Los Mediadores Concretos implementan el comportamiento cooperativo coordinando varios componentes.
    class ConcreteMediator : IMediator
    {
        private List<IColleague> colleagues;

        public ConcreteMediator()
        {
            colleagues = new List<IColleague>();
        }

        public void Add(IColleague colleague)
        {
            this.colleagues.Add(colleague);
        }

        public void Send(string message, IColleague colleague)
        {
            foreach (var c in this.colleagues)
            {
                if (colleague != c)
                {
                    c.Receive(message);
                }
            }
        }
    }
}
