
namespace SOLID.LSP.Solucao
{
    public class Retangulo : Paralelogramo
    {
        public double Altura { get; set; }

        public double Largura { get; set; }

        public override double Area()
        {
            return Altura * Largura;
        }
    }
}
