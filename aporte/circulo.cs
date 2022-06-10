using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte
{
     class circulo:figuras, IGEOMETRY
    {
        public double Radio { get; set; }
        

        public circulo(string nombre, string color, int Radio) : base (nombre, color)
        {
            this.Radio = Radio;
            
        }
        public void CalculoArea() { 
        double CPU;
            double area = Math.PI * Math.Pow(Radio, 2);
            
            Console.WriteLine("nombre:" + nombre);
            Console.WriteLine("color: " + color);
            Console.WriteLine("radio: " + Radio);
            CPU =  area;
            Console.WriteLine("el area del circulo es: " + CPU);
        }
}
}
