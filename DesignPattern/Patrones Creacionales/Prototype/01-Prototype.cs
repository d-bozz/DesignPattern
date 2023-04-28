using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._09_Prototype
{
    // PATRON CREACIONAL
    // Se utiliza cuando quiero crear un clon de un objeto y luego hacerle modificaciones a la copia
    // En caso de equivocacion puedo volver al objeto original
    public class Prototype : ICloneable
    {
        public int Patas { get; set; }
        public string Nombre { get; set; }
        public Detalles Rasgos { get; set; }

        public object Clone()
        {
            Prototype clonado = this.MemberwiseClone() as Prototype;
            Detalles detalles = new Detalles();
            detalles.Color = this.Rasgos.Color;
            detalles.Raza = this.Rasgos.Raza;
            clonado.Rasgos = detalles;
            return clonado;
        }

        public class Detalles
        { 
            public string Color { get; set; }
            public string Raza { get; set; }
        }
    }
}