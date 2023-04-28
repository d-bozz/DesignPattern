using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    /**
     * PATRON CREACIONAL
     * 
     * Este patron proporciona una interfaz para crear objetos en una superclase, 
     * pero permite que las subclases alteren el tipo de objetos que se crearán.
     * 
     * **/

    /** Creator **/
    // La clase Creator declara el método de fábrica que se supone que devolverá
    // un objeto de una clase de Producto. 
    public abstract class SaleFactory
    {
        // Interfaz del creator
        public abstract ISale GetSale();
    }


    /** Concrete Creator **/
    // Hereda de SaleFactory y sobreescribe el metodo para cambiar el tipo de producto
    public class StoreSaleFactory : SaleFactory
    {
        // Properties
        private decimal _extra;

        // Constructor
        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }

        // Metodo de SaleFactory
        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }


    /** Concrete Product **/
    // Hereda de la interfaz del producto y proporciona implementaciones
    public class StoreSale : ISale
    {
        // Properties
        private decimal _extra;

        // Contructor
        public StoreSale(decimal extra)
        {
            _extra = extra;
        }

        // Metodo
        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en TIENDA tiene un total de {total + _extra}");
        }
    }

    /** Product Interface **/
    // Declara las operaciones que todos los concrete products deben implementar
    public interface ISale
    {
        public void Sell(decimal total);
    }
}
