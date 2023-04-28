using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjectionPattern
{
    public class Beer
    {
        // Properties
        private string _name;
        private string _brand;

        // Getter y setter
        public string Name
        {
            get
            {
                return _name;
            }
        }

        // Constructor
        public Beer(string name, string brand, int a)
        {
            _name = name;
            _brand = brand;
        }
    }
}
