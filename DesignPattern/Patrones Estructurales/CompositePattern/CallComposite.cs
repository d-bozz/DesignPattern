using MediatorDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patrones_Estructurales.CompositePattern
{
    public  class CallComposite
    {
        static void Main(string[] args)
        {
            Leaf oLeaf = new Leaf("Harina", 100, 20, "gramos");
            Leaf oLeaf2 = new Leaf("Leche", 20, 1, "litro");
            Leaf oLeaf3 = new Leaf("Huevo", 20, 1, "kilo");

            Composite oComposite = new Composite("Pastel de leche");
            oComposite.Add(oLeaf);
            oComposite.Add(oLeaf2);
            oComposite.Add(oLeaf3);

            Console.WriteLine(oComposite.Costo);

            Leaf oLeaf4 = new Leaf("chocolate",299,1,"litro");
            Composite oCompositeCompuesto = new Composite("Pastel compuesto");

            oCompositeCompuesto.Add(oLeaf4);
            oCompositeCompuesto.Add(oComposite);

            Console.WriteLine(oCompositeCompuesto.CostoTotal);
        }
    }
}
