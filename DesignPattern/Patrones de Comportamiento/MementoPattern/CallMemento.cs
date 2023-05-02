using MediatorDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patrones_de_Comportamiento.MementoPattern
{
    public class CallMemento
    {
        static CareTaker caretaker = new CareTaker();

        static void Main(string[] args)
        {
            var p = new Originator();
            p.Nombre = "Pepe";

            caretaker.Add(p.saveToMemento());

            p.Nombre = "Pepe1";
            caretaker.Add(p.saveToMemento());


            p.Nombre = "Pepe2";
            caretaker.Add(p.saveToMemento());


            Memento m1 = caretaker.GetMemento(0);
            Console.WriteLine("Viendo memento 1: " + m1.Estado);
            Console.WriteLine("Viendo memento 2: " + caretaker.GetMemento(1).Estado);
            Console.WriteLine("Viendo memento 3: " + caretaker.GetMemento(2).Estado);

            p.restoreToMemento(m1);

            p.restoreToMemento(caretaker.GetMemento(1));
            Console.ReadKey();

        }
    }
}
