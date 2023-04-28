using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SingletonPattern
{
    /**
     * 
     * Patron de diseño de tipo CREACIONAL 
     * El objetivo de este patron es garantizar la existencia de una sola instancia de una clase. 
     * Además el acceso a esa única instancia tiene que ser global.
     * 
     * **/

    // La clase se delcara 'sealed' para evitar que sea modificada en la herencia
    public sealed class Singleton
    {

        // El constructor debe ser siempre private para evitar que se llame con el new 
        private Singleton() { }

        // La instancia se guarda en un campo static 
        private static Singleton _instance;

        // Metodo static que controla el acceso a la instancia de singleton
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
