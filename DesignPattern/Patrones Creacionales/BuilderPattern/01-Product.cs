using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._07_BuilderPattern
{
    // Tiene sentido usar el patrón Builder solo cuando los productos son
    // bastante complejos y requieren una configuración extensa.
    public class Product
    {
        public List<string> Ingredients = new List<string>();
        public int Milk;
        public int Water;
        public decimal Alcohol;

        public string Result;
    }
}
