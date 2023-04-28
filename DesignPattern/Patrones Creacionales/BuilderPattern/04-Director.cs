using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._07_BuilderPattern
{
    // El Director solo es responsable de ejecutar los pasos de construcción en una secuencia particular.
    // Es útil cuando se fabrican productos de acuerdo con un orden o configuración específica.
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder) 
        { 
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        // El Director puede construir variaciones de productos usando los mismos pasos de construcción.
        public void PrepareMargarita()
        {
            _builder.Reset();
            _builder.SetAlcohol(9);
            _builder.SetWater(30);
            _builder.AddIngredients("2 limones");
            _builder.AddIngredients("pizca de sal");
            _builder.AddIngredients("1/2 taza de tequila");
            _builder.AddIngredients("3/4 tazas de licor de naranja");
            _builder.AddIngredients("4 cubos de hielo");
            _builder.Mix();
            _builder.Rest(1000);
        }

        public void PreparePiñaColada()
        {
            _builder.Reset();
            _builder.SetAlcohol(20);
            _builder.SetWater(10);
            _builder.SetMilk(500);
            _builder.AddIngredients("1/2 ron");
            _builder.AddIngredients("1/2 crema de coco");
            _builder.AddIngredients("3/4 jugo de piña");
            _builder.AddIngredients("4 cubos de hielo");
            _builder.Mix();
            _builder.Rest(2000);
        }
    }
}
