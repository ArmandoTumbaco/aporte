namespace aporte { 
    class Program
{
        public static void Main(string[] args)
        {
            cuadrado Forza1 = new cuadrado("cuadrado", "moradiso", 10);
            

            rectangulo Forza2 = new rectangulo("RECTANGULO", "BLANQUISO", 6, 3);
            

            circulo Forza3 = new circulo("circulo", "marronazul", 7);
            

            List<figuras> Las_listas = new List<figuras>();
            Las_listas.Add(Forza1);
            Las_listas.Add(Forza2);
            Las_listas.Add(Forza3);

            foreach (IGEOMETRY GTA5 in Las_listas)
            {
                GTA5.CalculoArea();
            }


        }
}
}
