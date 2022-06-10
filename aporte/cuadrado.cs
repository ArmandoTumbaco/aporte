using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte
{
     class cuadrado:figuras, IGEOMETRY
    {
     public int lados { get; set; }

        public cuadrado(string nombre,  string color, int lados) : base (nombre, color)
        {
            this.lados = lados;
        }
        public void CalculoArea() {
        int Resul;
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("lados: "+lados);
            Console.WriteLine("color: " + color);
            Resul =lados * lados;
            Console.WriteLine("el calculo del area del cuadrado es: " + Resul);
               
        }
}
}
