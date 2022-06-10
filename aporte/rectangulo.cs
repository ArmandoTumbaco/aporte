using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte
{
     class rectangulo :figuras, IGEOMETRY
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public rectangulo(string nombre, string color,int Base, int Altura) : base(nombre, color)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        public void CalculoArea()
        {
            int Resul;
            Console.WriteLine("nombre:" + nombre);
            Console.WriteLine("color: " + color);
            Console.WriteLine("BASE: " + Base);
            Console.WriteLine("altura:" + Altura);
            Resul = Base * Altura;
            Console.WriteLine("el area del rectangulo es: " + Resul);
        }
}
}
