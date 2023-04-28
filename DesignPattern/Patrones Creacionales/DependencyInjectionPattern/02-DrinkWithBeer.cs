using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjectionPattern
{
    /**
     * 
     * Patron que se asocia a los creacionales
     * Permite quitar la responsabilidad de una clase de crear objetos a partir de otra
     * Se trata de extraer responsabilidades a un componente para delegarlas a otros componentes, 
     * de tal manera que cada componente solo tiene una responsabilidad (Principio de Responsabilidad Única)
     * 
     * **/

    public class DrinkWithBeer
    {
        // Creamos un objeto de tipo Beer
        private Beer _beer;
        private decimal _water;
        private decimal _sugar;

        // Lo mandamos en el constructor por medio de la inyeccion de dependencias
        public DrinkWithBeer(decimal water, decimal sugar, Beer beer)
        {
            _water = water;
            _sugar = sugar;
            _beer = beer;
        }
        public void Build()
        {
            Console.WriteLine($"Preparamos bebida que tiene agua {_water} " +
                $" azúcar {_sugar} y cerveza {_beer.Name}");
        }

    }
}
