
namespace SOLID.LSP.Solucao
{
    public class Quadrado : Paralelogramo
    {
        public double Lado { get; set; }

        public override double Area()
        {
            return Lado * Lado;
        }
    }
}
