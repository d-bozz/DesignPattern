using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern._07_BuilderPattern
{
    // La clase ConcreteBuilder hereda de IBuilder y proporciona la definicion de los metodos
    public class ConcreteBuilder : IBuilder
    {
        private Product _product;

        // En el constructor se llama al objeto Reset donde se crea una nueva instancia del objeto Producto
        public ConcreteBuilder()
        {
            Reset();
        }

        public void AddIngredients(string ingredients)
        {
            if (_product.Ingredients == null) 
                _product.Ingredients = new List<string>();
        
            _product.Ingredients.Add(ingredients);
        }

        public void Mix()
        {
            string ingredients = _product.Ingredients.Aggregate((i, j) => i + ", " + j);
            _product.Result = $"Bebida preparada con {_product.Alcohol} de alcohol" +
                $"con los siguientes ingredientes; {ingredients}";
            Console.WriteLine("Mezclamos los ingredientes");
        }

        public void Reset()
        {
            _product = new Product();
        }

        public void Rest(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine("Listo para beberse");
        }

        public void SetAlcohol(decimal alcohol)
        {
            _product.Alcohol = alcohol;
        }

        public void SetMilk(int milk)
        {
            _product.Milk = milk;
        }

        public void SetWater(int water)
        {
            _product.Water = water;
        }

        // Se crea este metodo en el ConcreteBuilder para mostrar resultados.
        // Esto debido a que varios tipos de builders pueden crear productos diferentes que no siguen la misma interfaz.
        public Product GetProduct() => _product;
    }
}