
namespace SOLID.OCP.Solucao
{
    public class Triangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return (Base * Altura) * 0.5;
        }
    }
}
