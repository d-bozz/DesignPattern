using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._09_Prototype
{
    public class CallPrototype
    {
        static void Main(string[] args)
        {
            Prototype oveja = new Prototype() 
            { 
                Nombre = "Dolly",
                Patas = 4,
                Rasgos = { Color = "Blanca", Raza = "Merino" }

            };

            // Implemento un objeto clon con las mismas propiedades
            Prototype ovejaClonada = oveja.Clone() as Prototype;

            // Modifico el objeto clonado
            ovejaClonada.Rasgos.Color = "negro";

            Console.WriteLine(oveja.Rasgos.Color);
            Console.WriteLine(ovejaClonada.Rasgos.Color);
        }
    }
}