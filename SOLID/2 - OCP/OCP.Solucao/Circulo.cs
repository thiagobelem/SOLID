using System;

namespace SOLID.OCP.Solucao
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }

        public override double Area()
        {
            return (Raio * Raio) * Math.PI;
        }
    }
}
